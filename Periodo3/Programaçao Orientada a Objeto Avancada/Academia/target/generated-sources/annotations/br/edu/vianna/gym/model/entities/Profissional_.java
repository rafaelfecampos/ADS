package br.edu.vianna.gym.model.entities;

import br.edu.vianna.gym.model.entities.Consulta;
import br.edu.vianna.gym.model.entities.Ficha;
import javax.annotation.processing.Generated;
import javax.persistence.metamodel.ListAttribute;
import javax.persistence.metamodel.SetAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="org.eclipse.persistence.internal.jpa.modelgen.CanonicalModelProcessor", date="2024-05-11T14:58:20", comments="EclipseLink-2.7.7.v20200504-rNA")
@StaticMetamodel(Profissional.class)
public class Profissional_ extends User_ {

    public static volatile ListAttribute<Profissional, Consulta> consultas;
    public static volatile SetAttribute<Profissional, Ficha> fichas;

}