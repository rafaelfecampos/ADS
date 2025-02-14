package br.edu.vianna.gym.model.entities;

import br.edu.vianna.gym.model.entities.Aluno;
import br.edu.vianna.gym.model.entities.Profissional;
import java.util.Date;
import javax.annotation.processing.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="org.eclipse.persistence.internal.jpa.modelgen.CanonicalModelProcessor", date="2024-05-11T14:58:20", comments="EclipseLink-2.7.7.v20200504-rNA")
@StaticMetamodel(Consulta.class)
public class Consulta_ { 

    public static volatile SingularAttribute<Consulta, Aluno> aluno;
    public static volatile SingularAttribute<Consulta, String> resultado;
    public static volatile SingularAttribute<Consulta, Boolean> confirmado;
    public static volatile SingularAttribute<Consulta, Integer> id;
    public static volatile SingularAttribute<Consulta, Date> dataConsulta;
    public static volatile SingularAttribute<Consulta, Boolean> finalizado;
    public static volatile SingularAttribute<Consulta, Profissional> profissional;

}