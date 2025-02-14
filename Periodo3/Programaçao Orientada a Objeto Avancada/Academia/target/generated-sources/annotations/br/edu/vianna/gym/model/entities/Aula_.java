package br.edu.vianna.gym.model.entities;

import br.edu.vianna.gym.model.entities.Aluno;
import br.edu.vianna.gym.model.entities.Instrutor;
import br.edu.vianna.gym.model.enums.ETipoAula;
import java.util.Date;
import javax.annotation.processing.Generated;
import javax.persistence.metamodel.SetAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="org.eclipse.persistence.internal.jpa.modelgen.CanonicalModelProcessor", date="2024-05-11T14:58:20", comments="EclipseLink-2.7.7.v20200504-rNA")
@StaticMetamodel(Aula.class)
public class Aula_ { 

    public static volatile SingularAttribute<Aula, Instrutor> instrutor;
    public static volatile SingularAttribute<Aula, Integer> numMaxAlunos;
    public static volatile SetAttribute<Aula, Aluno> alunos;
    public static volatile SingularAttribute<Aula, Date> dataAula;
    public static volatile SingularAttribute<Aula, Boolean> confirmado;
    public static volatile SingularAttribute<Aula, Integer> id;
    public static volatile SingularAttribute<Aula, Boolean> finalizado;
    public static volatile SingularAttribute<Aula, ETipoAula> tipoAula;
    public static volatile SingularAttribute<Aula, Boolean> full;

}