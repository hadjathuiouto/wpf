using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoWpf.Models;

namespace TutoWpf.Data
{
    public class DailyService : IDailyService
    {
        public IEnumerable<Daily> GetAll()
        {
            yield return new Daily { Task = "Lecture", Description = "Lecture de quelques pages d'un livre pendant 30min", Details = "Actuellement je lis le roman de Michele Obama Devenir", Goal = "L'objetcif derrière c'est pour se construire une vie de rêve" };
            yield return new Daily { Task = "Coran", Description = "Lire un djuzu tous les jours afin de finir le coran tous les mois", Details = "Actuellement je suis au djuzu 2", Goal = "Construire une certaine proximité avec Dieu et surtout m'apaiser le coeur" };
            yield return new Daily { Task = "Discours", Description = "Discours pour s'entraîner à la prise de parole en public", Details = "Faire 2min d'articulation, 3min de lecture haute, 5min d'improvisation et de dissertation", Goal = "Etre éloquent" };
            yield return new Daily { Task = "Anglais", Description = "Ecouter des vidéos en anglais tous les jours pendant 10min", Details = "Actuelellement j'écoute les vidéos de Kansiime Anne", Goal = "Parler couramment l'anglais" };
            yield return new Daily { Task = "Culture Générale", Description = "Ecouter le journal pour savoir ce qui se passe dans le monde", Details = "Actuellement je suis basée plus sur france 24 et RFI", Goal = "Etre au parfum sur tout ce qui se passe dans le monde" };
            yield return new Daily { Task = "Informatique", Description = "Pisser du code tous les jours pour être plus performant", Details = "Travailler sur mes projets pero et me balder sur pluralsight", Goal = "Devenir un génie du code" };
            yield return new Daily { Task = "Bien-être", Description = "S'occuper de ma peau et de mon apparence", Details = "Faire des masques, prendre des douches, faire des soins", Goal = "La beauté au rendez-vous, sublime sublime" };

        }
    }
}
