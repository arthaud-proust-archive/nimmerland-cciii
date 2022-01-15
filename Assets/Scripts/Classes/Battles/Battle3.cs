using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle3 : Battle
    {
        public Battle3() : base() { }

        public override void FillScene()
        {

            //Background = Resources.Load<Sprite>("Sprites/Background/bg_foret");
            Background = Resources.Load<Sprite>("New_Ritter_Von_Platz");
            Music = "music-3";
            DialogsBefore = new List<Dialog>{
                new Dialog(Heroes[0], "Gla-gla-gla-gla-gla..."),
                new Dialog(Heroes[0], "La chaleur intense du désert commencerait presque à me manquer..."),
                new Dialog(Heroes[1], "Dites... Sir Platz... Votre cicatrice vous fait mal ? Je vous vois la toucher depuis tout à l'heure."),
                new Dialog(Heroes[2], "Ah... Oui, le froid mordant ne fait pas bon ménage avec les plaies en général."),
                new Dialog(Heroes[2], "Mais au-delà de ça, c'est comme s'il était dans les parages, cette présence me met dans un mauvais état..."),
                new Dialog(Heroes[1], "Je vois..."),
                new Dialog(Heroes[0], "???"),
                new Dialog(Heroes[0], "Mais de qui, que, quoi vous parlez ?"),
                new Dialog(Heroes[0], "D'ailleurs j'y pense môsseigneur le chevalier chevaleresque, d'où vous vient cette cicatrice ?"),
                new Dialog(Heroes[1], "Il n'aime pas trop en parler, alors je vais le faire pour lui."),
                new Dialog(Heroes[1], "Comme tu le sais, Messire Ritter von Platz est un chevalier vétéran."),
                new Dialog(Heroes[1], "Par conséquent il a déjà fait partie d'une escouade par le passé, et-..."),
                new Dialog(Heroes[2], "Et c'est dans cette escouade que j'ai découvert mon mentor."),
                new Dialog(Heroes[1], "Messire j'étais en train d-..."),
                new Dialog(Heroes[2], "Ne t'en fais pas Kirchlich, je prends le relais."),
                new Dialog(Heroes[2], "Krieger von Schwarz, mon mentor donc, est un guerrier exceptionnel."),
                new Dialog(Heroes[2], "C'est grâce à lui que je sais aussi bien me battre aujourd'hui."),
                new Dialog(Heroes[0], "Ah oui ! Ce n'est pas n'importe qui, mais du coup, quel est le rapport avec votre cicatrice...?"),
                new Dialog(Heroes[2], "J'y viens."),
                new Dialog(Heroes[2], "Je servais Krieger en tant qu'écuyer dans son escouade."),
                new Dialog(Heroes[2], "Nous étions d'ailleurs la meilleure escouade de Nimmerland à cette époque, personne ne nous resistait."),
                new Dialog(Heroes[2], "Néanmoins au fur et à mesure que nous progressions vers la source du mal, le mental de Krieger semblait changer..."),
                new Dialog(Heroes[2], "C'était comme s'il sombrer peu à peu dans le péché, lui qui était le plus noble des chevaliers."),
                new Dialog(Heroes[2], "Un soir, alors que nous étions en patrouille dans ces mêmes montagnes qu'actuellement..."),
                new Dialog(Heroes[2], "J'entendis les echos d'un combat d'épée en dehors de ma tente."),
                new Dialog(Heroes[2], "Je me suis donc munis instinctivement de ma lame et de mon bouclier et en sortant je vis..."),
                new Dialog(Heroes[2], "Je vis Krieger en train de massacrer mes anciens compagnons, ses anciens disciples..."),
                new Dialog(Heroes[2], "J'ai donc dû me combattre contre celui qui m'a tout appris, et..."),
                new Dialog(Heroes[2], "..."),
                new Dialog(Heroes[2], "J'ai perdu."),
                new Dialog(Heroes[2], "L'acier de sa claymore a eu raison de mon oeil et d'une partie de mon visage comme tu peux le voir."),
                new Dialog(Heroes[2], "J'ai été brisé ce jour là, et si Runden, que je ne connaissais pas encore, n'était pas dans les parrages..."),
                new Dialog(Heroes[2], "Je ne sais pas ce qui me serait arrivé."),
                new Dialog(Heroes[1], "Messire, ce fut un honneur de vous sauver des griffes de la mort."),
                new Dialog(Heroes[0], "W-Whaouh..."),
                new Dialog(Heroes[2], "Enfin bref, il suffit pour les tirades nous avons mieux à f-..."),
                new Dialog(Heroes[1], "Qu'est-ce que...?"),
                new Dialog(new EnemyUnknown(), "*Rires graves*"),
                new Dialog(Heroes[0], "Qu-Qui va là ?!"),
                new Dialog(new EnemyUnknown(), "Mouahahah... Et bien, Ritter, quelle tête nous fais-tu ?"),
                new Dialog(new EnemyUnknown(), "On dirait que tu as vu un fantôme..."),
                new Dialog(Heroes[2], "..."),
                new Dialog(Heroes[1], "Me...Messire...? Est-ce...?"),
                new Dialog(Heroes[2], "...C'est bien lui oui."),
                new Dialog(Heroes[2], "Krieger."),

                new Dialog(Enemies[0], "Je ne m'attendais pas à te revoir ici. La première fois ne t'as pas suffit ?"),
                new Dialog(Enemies[0], "Devrais-je donc te trancher le second oeil pour te faire comprendre les liens qui nous unissent désormais ?"),
                new Dialog(Heroes[0], "ALORS VOUS ! V-VOUS ALLEZ VOIR !"),
                new Dialog(Heroes[0], "OUAIS !"),
                new Dialog(Heroes[0], "VOUS ALLEZ VOIR CE QUE VOUS ALLEZ VOIR ! ON VA V-"),
                new Dialog(Heroes[2], "SILENCE MAGY !"),
                new Dialog(Heroes[0], "H-hein... J-Je..."),
                new Dialog(Heroes[0], "Krieger... Je ne comprends toujours pas... Pourquoi es-tu devenu ainsi...?"),
                new Dialog(Enemies[0], "Toutes ces années, j'ai combattu le mal, j'ai éxorcisé ce qui devait l'être."),
                new Dialog(Enemies[0], "Mais je ne voyais simplement pas le bon côté des choses..."),
                new Dialog(Enemies[0], "Le mal... C'est... Le droit chemin... Le chemin vers, LA PUISSANCE INÉGALÉE !"),
                new Dialog(Heroes[1], "Il est devenu complètement dingue."),
                new Dialog(Heroes[0], "Réglons lui son compte ! Vite !"),
                new Dialog(Heroes[2], "Tsss, vieux fou ! ta soif de pouvoir t'empêche de garder la raison."),
                new Dialog(Heroes[2], "J'ai perdu contre toi une première fois, mais cette fois je ne suis pas seul."),
                new Dialog(Enemies[0], "Hmm hmm..."),
                new Dialog(Enemies[0], "Vous écraser tous les trois comme de vulgaires insectes ne sera qu'une marche supplémentaire vers mon ascension au sommet..."),
                new Dialog(Enemies[0], "ALLEZ ! AMÈNES-TOI !"),
                new Dialog(Enemies[0], "Viens te faire embrocher à nouveau... RITTEEEEEEEEEEEEEER !"),
                new Dialog(Heroes[2], "Choisis un dieu... et pries-le, ton heure a sonnée... KRIEGEEEEEEEEEEEEER !"),

            };
            DialogsAfter = new List<Dialog>{
                new Dialog(Enemies[0], "Tu... Tu es devenu fort Ritter…"),
                new Dialog(Heroes[0], "Il .. Il a ... Il a encore l'énergie pour parler ?!"),
                new Dialog(Heroes[1], "Visiblement..."),
                new Dialog(Heroes[2], "Maintenant parle Krieger ! Pourquoi fais-tu tout cela ?!"),
                new Dialog(Enemies[0], "Kof...kof..."),
                new Dialog(Enemies[0], "Ce prêtre... avec le signe sur sa tête ... béni par le dieu de ce monde ..."),
                new Dialog(Enemies[0], "PAR QUEL MÉRITE A-T-IL REÇU UN TEL POUVOIR ?!"),
                new Dialog(Enemies[0], "Et cette mage exaspérante..."),
                new Dialog(Enemies[0], "QUI A DÉCIDÉ QU'ELLE NAîTRAIT AVEC UN TEL TALENT ?!"),
                new Dialog(Enemies[0], "HEIN ?! QUI ?!"),
                new Dialog(Enemies[0], "Et puis toi Ritter..."),
                new Dialog(Enemies[0], "Jeune prodige ... Exemplaire depuis ton plus jeune âge..."),
                new Dialog(Enemies[0], "Vous ne méritez pas d'être aussi gâtés par la nature !"),
                new Dialog(Heroes[2], "Qu'est ce que tu racontes, on a travaillé dur pour en arriver là !"),
                new Dialog(Enemies[0], "BALIVERNES ! Le destin vous a choyé depuis le départ."),
                new Dialog(Enemies[0], "VOUS."),
                new Dialog(Enemies[0], "N'AVEZ."),
                new Dialog(Enemies[0], "MÉRITE !"),
                new Dialog(Enemies[0], "Kof...kof..."),
                new Dialog(Heroes[0], "Garde ta salive, monstre..."),
                new Dialog(Heroes[1], "Nous devons en finir au plus vite !"),
                new Dialog(Heroes[2], "Pas encore... Je dois en savoir un peu plus sur ses réelles ambitions..."),
                new Dialog(Enemies[0], "Mes vrais ambitions ?"),
                new Dialog(Enemies[0], "Ahah..."),
                new Dialog(Enemies[0], "C'est simple..."),
                new Dialog(Enemies[0], "DEVENIR UN DIEU VIVANT !"),
                new Dialog(Heroes[1], "C'est tout simplement impossible !"),
                new Dialog(Heroes[2], "PRetrouve la raison ! Tu délires Krieger !"),
                new Dialog(Enemies[0], "Les bandits pour capturer les êtres insignifiants..."),
                new Dialog(Enemies[0], "la sorcière pour extraire leur énergie vitale..."),
                new Dialog(Enemies[0], "Et moi..."),
                new Dialog(Enemies[0], "Pour me nourrir de toute leur essence !"),
                new Dialog(Heroes[1], "Cruauté ! Blasphémie ! ABJECTION !"),
                new Dialog(Heroes[0], "*Vomit*"),
                new Dialog(Heroes[2], "Magy !"),
                new Dialog(Heroes[1], "Vous ne pouvez pas recevoir ses énergies vitales ! C'est... c'est contre les règles..."),
                new Dialog(Enemies[0], "Hm hm..."),
                new Dialog(Enemies[0], "Ah ah..."),
                new Dialog(Enemies[0], "AHAHAHAH !"),
                new Dialog(Enemies[0], "Celui qui fixe les règles..."),
                new Dialog(Enemies[0], "CE N'EST NUL AUTRE QUE MOI !"),



                new Dialog(Heroes[2], "QU'EST-CE QUI SE PASSE ?!"),
                new Dialog(Heroes[0], "Je .. je suis fatigué .."),
                new Dialog(Heroes[1], "Sir Platz ?! Où êtes-vous ?!"),
                new Dialog(Heroes[2], "Messire ?!"),
                new Dialog(Heroes[2], "MESSIRE ?!"),

            };
        }
        public override void FillEnemies()
        {
            Enemies.Add(new Enemy3());
        }
    }
}