package br.edu.vianna.gym.model.entities;

import br.edu.vianna.gym.model.entities.Aluno;
import br.edu.vianna.gym.model.entities.Profissional;
import javax.annotation.processing.Generated;
import javax.persistence.metamodel.SetAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="org.eclipse.persistence.internal.jpa.modelgen.CanonicalModelProcessor", date="2024-05-11T14:58:20", comments="EclipseLink-2.7.7.v20200504-rNA")
@StaticMetamodel(Ficha.class)
public class Ficha_ { 

    public static volatile SingularAttribute<Ficha, String> exercicios;
    public static volatile SingularAttribute<Ficha, Aluno> aluno;
    public static volatile SingularAttribute<Ficha, String> recomendacoes;
    public static volatile SingularAttribute<Ficha, Integer> id;
    public static volatile SetAttribute<Ficha, Profissional> profissionais;
    public static volatile SingularAttribute<Ficha, String> dieta;

}