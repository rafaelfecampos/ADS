package br.edu.vianna.gym.model;

import br.edu.vianna.gym.model.entities.Aluno;

import javax.annotation.processing.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="org.eclipse.persistence.internal.jpa.modelgen.CanonicalModelProcessor", date="2024-05-08T11:43:56", comments="EclipseLink-2.7.7.v20200504-rNA")
@StaticMetamodel(Aluno.class)
public class Aluno_ extends User_ {

    public static volatile SingularAttribute<Aluno, Integer> idade;
    public static volatile SingularAttribute<Aluno, Double> peso;
    public static volatile SingularAttribute<Aluno, Integer> id_aluno;
    public static volatile SingularAttribute<Aluno, String> email;

}