import jsonwebtoken from "jsonwebtoken";
import dotenv from "dotenv";

dotenv.config();

export const PRIVATE_KEY = process.env.PRIVATE_KEY;
export const  user = {
    name: "Ze da Silva",
    email: "zezinho@example.com"
}

export function tokenValidated(
    req,
    res,
    next
){
    const [, token] = req.headers.authorization?.split(" ") || [" ", " "];

    if(!token){
        return res.status(401).send("Denied access. No token provided!")
    }

    try{
        const payload = jsonwebtoken.verify(token, PRIVATE_KEY);
        const userIdFromToken = typeof payload !== "string" && payload.user;

        if(!user && !userIdFromToken) {
            return res.send(401).json({message: "Invalid token"});
        }

        req.headers['user'] = payload.user;

        return next();
    }catch(error){
        console.log(error);
        return res.status(401).json({
            message: "Invalid Token"
        });
    }
}