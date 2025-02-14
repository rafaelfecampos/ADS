package br.edu.vianna.gym.model.entities;

import br.edu.vianna.gym.model.entities.Aula;
import br.edu.vianna.gym.model.entities.Consulta;
import br.edu.vianna.gym.model.entities.Ficha;
import javax.annotation.processing.Generated;
import javax.persistence.metamodel.ListAttribute;
import javax.persistence.metamodel.SetAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="org.eclipse.persistence.internal.jpa.modelgen.CanonicalModelProcessor", date="2024-05-11T14:58:20", comments="EclipseLink-2.7.7.v20200504-rNA")
@StaticMetamodel(Aluno.class)
public class Aluno_ extends User_ {

    public static volatile SingularAttribute<Aluno, Integer> idade;
    public static volatile SingularAttribute<Aluno, Double> peso;
    public static volatile SingularAttribute<Aluno, Ficha> ficha;
    public static volatile ListAttribute<Aluno, Aula> aulas;
    public static volatile SetAttribute<Aluno, Consulta> consultas;
    public static volatile SingularAttribute<Aluno, String> email;

}