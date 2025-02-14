const clientID = "srf24uvtamhv830tzx27vyhv69f6fb";
const clientSecret = "vv48ug816b3hx5zpe4ppb9oddip53a";

const getToken = async () => {
    const result = await fetch("https://id.twitch.tv/oauth2/token", {
        method: "POST",
        headers: {
            "Content-Type": "application/x-www-form-urlencoded",
        },
        body: new URLSearchParams({
            "client_id": clientID,
            "client_secret": clientSecret,
            "grant_type": "client_credentials"
        })
    });

    if (!result.ok) {
        const error = await result.text();
        throw new Error(`Error fetching token: ${error}`);
    }

    const data = await result.json();

    return data.access_token;
}



const getEmotes = async (token) =>{ //coloquei pra retornar o link das imagens que correspondem aos emotes
    const result = await fetch(`https://api.twitch.tv/helix/chat/emotes/global`, {
        method: "GET",
        headers: {
            "Authorization": "Bearer " + token,
            "Client-Id": clientID,
        }
    });

    const data = await result.json();
    return data.data.map(x =>{ return {id:x.id, name: x.name, url_images: x.images}});

}

const getChatBadges = async (token) =>{
    const result = await fetch(`https://api.twitch.tv/helix/chat/badges/global`,{
        method: "GET",
        headers: {
            "Authorization": "Bearer " + token,
            "Client-Id": clientID,
        }
    });
    const data = await result.json();
    return data;
}

(async () => {
    try {
        const token = await getToken();
        console.log(token);        
        const games = await getEmotes(token);
        console.log(games);
        const badges = await getChatBadges(token);
        console.log(badges);
        
    } catch (error) {
        console.error(error);
    }
})();
