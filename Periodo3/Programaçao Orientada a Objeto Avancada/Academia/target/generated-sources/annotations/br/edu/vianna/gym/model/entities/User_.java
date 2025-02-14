package br.edu.vianna.gym.model.entities;

import br.edu.vianna.gym.model.enums.ETipoUsuario;
import javax.annotation.processing.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="org.eclipse.persistence.internal.jpa.modelgen.CanonicalModelProcessor", date="2024-05-11T14:58:20", comments="EclipseLink-2.7.7.v20200504-rNA")
@StaticMetamodel(User.class)
public class User_ { 

    public static volatile SingularAttribute<User, String> senha;
    public static volatile SingularAttribute<User, String> nome;
    public static volatile SingularAttribute<User, ETipoUsuario> tipoUsuario;
    public static volatile SingularAttribute<User, Integer> id;
    public static volatile SingularAttribute<User, String> login;

}