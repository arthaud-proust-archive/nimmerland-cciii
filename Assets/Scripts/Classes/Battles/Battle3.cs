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
                new Dialog(Heroes[0], "La chaleur intense du d�sert commencerait presque � me manquer..."),
                new Dialog(Heroes[1], "Dites... Sir Platz... Votre cicatrice vous fait mal ? Je vous vois la toucher depuis tout � l'heure."),
                new Dialog(Heroes[2], "Ah... Oui, le froid mordant ne fait pas bon m�nage avec les plaies en g�n�ral."),
                new Dialog(Heroes[2], "Mais au-del� de �a, c'est comme s'il �tait dans les parages, cette pr�sence me met dans un mauvais �tat..."),
                new Dialog(Heroes[1], "Je vois..."),
                new Dialog(Heroes[0], "???"),
                new Dialog(Heroes[0], "Mais de qui, que, quoi vous parlez ?"),
                new Dialog(Heroes[0], "D'ailleurs j'y pense m�sseigneur le chevalier chevaleresque, d'o� vous vient cette cicatrice ?"),
                new Dialog(Heroes[1], "Il n'aime pas trop en parler, alors je vais le faire pour lui."),
                new Dialog(Heroes[1], "Comme tu le sais, Messire Ritter von Platz est un chevalier v�t�ran."),
                new Dialog(Heroes[1], "Par cons�quent il a d�j� fait partie d'une escouade par le pass�, et-..."),
                new Dialog(Heroes[2], "Et c'est dans cette escouade que j'ai d�couvert mon mentor."),
                new Dialog(Heroes[1], "Messire j'�tais en train d-..."),
                new Dialog(Heroes[2], "Ne t'en fais pas Kirchlich, je prends le relais."),
                new Dialog(Heroes[2], "Krieger von Schwarz, mon mentor donc, est un guerrier exceptionnel."),
                new Dialog(Heroes[2], "C'est gr�ce � lui que je sais aussi bien me battre aujourd'hui."),
                new Dialog(Heroes[0], "Ah oui ! Ce n'est pas n'importe qui, mais du coup, quel est le rapport avec votre cicatrice...?"),
                new Dialog(Heroes[2], "J'y viens."),
                new Dialog(Heroes[2], "Je servais Krieger en tant qu'�cuyer dans son escouade."),
                new Dialog(Heroes[2], "Nous �tions d'ailleurs la meilleure escouade de Nimmerland � cette �poque, personne ne nous resistait."),
                new Dialog(Heroes[2], "N�anmoins au fur et � mesure que nous progressions vers la source du mal, le mental de Krieger semblait changer..."),
                new Dialog(Heroes[2], "C'�tait comme s'il sombrer peu � peu dans le p�ch�, lui qui �tait le plus noble des chevaliers."),
                new Dialog(Heroes[2], "Un soir, alors que nous �tions en patrouille dans ces m�mes montagnes qu'actuellement..."),
                new Dialog(Heroes[2], "J'entendis les echos d'un combat d'�p�e en dehors de ma tente."),
                new Dialog(Heroes[2], "Je me suis donc munis instinctivement de ma lame et de mon bouclier et en sortant je vis..."),
                new Dialog(Heroes[2], "Je vis Krieger en train de massacrer mes anciens compagnons, ses anciens disciples..."),
                new Dialog(Heroes[2], "J'ai donc d� me combattre contre celui qui m'a tout appris, et..."),
                new Dialog(Heroes[2], "..."),
                new Dialog(Heroes[2], "J'ai perdu."),
                new Dialog(Heroes[2], "L'acier de sa claymore a eu raison de mon oeil et d'une partie de mon visage comme tu peux le voir."),
                new Dialog(Heroes[2], "J'ai �t� bris� ce jour l�, et si Runden, que je ne connaissais pas encore, n'�tait pas dans les parrages..."),
                new Dialog(Heroes[2], "Je ne sais pas ce qui me serait arriv�."),
                new Dialog(Heroes[1], "Messire, ce fut un honneur de vous sauver des griffes de la mort."),
                new Dialog(Heroes[0], "W-Whaouh..."),
                new Dialog(Heroes[2], "Enfin bref, il suffit pour les tirades nous avons mieux � f-..."),
                new Dialog(Heroes[1], "Qu'est-ce que...?"),
                new Dialog(new EnemyUnknown(), "*Rires graves*"),
                new Dialog(Heroes[0], "Qu-Qui va l� ?!"),
                new Dialog(new EnemyUnknown(), "Mouahahah... Et bien, Ritter, quelle t�te nous fais-tu ?"),
                new Dialog(new EnemyUnknown(), "On dirait que tu as vu un fant�me..."),
                new Dialog(Heroes[2], "..."),
                new Dialog(Heroes[1], "Me...Messire...? Est-ce...?"),
                new Dialog(Heroes[2], "...C'est bien lui oui."),
                new Dialog(Heroes[2], "Krieger."),

                new Dialog(Enemies[0], "Je ne m'attendais pas � te revoir ici. La premi�re fois ne t'as pas suffit ?"),
                new Dialog(Enemies[0], "Devrais-je donc te trancher le second oeil pour te faire comprendre les liens qui nous unissent d�sormais ?"),
                new Dialog(Heroes[0], "ALORS VOUS ! V-VOUS ALLEZ VOIR !"),
                new Dialog(Heroes[0], "OUAIS !"),
                new Dialog(Heroes[0], "VOUS ALLEZ VOIR CE QUE VOUS ALLEZ VOIR ! ON VA V-"),
                new Dialog(Heroes[2], "SILENCE MAGY !"),
                new Dialog(Heroes[0], "H-hein... J-Je..."),
                new Dialog(Heroes[0], "Krieger... Je ne comprends toujours pas... Pourquoi es-tu devenu ainsi...?"),
                new Dialog(Enemies[0], "Toutes ces ann�es, j'ai combattu le mal, j'ai �xorcis� ce qui devait l'�tre."),
                new Dialog(Enemies[0], "Mais je ne voyais simplement pas le bon c�t� des choses..."),
                new Dialog(Enemies[0], "Le mal... C'est... Le droit chemin... Le chemin vers, LA PUISSANCE IN�GAL�E !"),
                new Dialog(Heroes[1], "Il est devenu compl�tement dingue."),
                new Dialog(Heroes[0], "R�glons lui son compte ! Vite !"),
                new Dialog(Heroes[2], "Tsss, vieux fou ! ta soif de pouvoir t'emp�che de garder la raison."),
                new Dialog(Heroes[2], "J'ai perdu contre toi une premi�re fois, mais cette fois je ne suis pas seul."),
                new Dialog(Enemies[0], "Hmm hmm..."),
                new Dialog(Enemies[0], "Vous �craser tous les trois comme de vulgaires insectes ne sera qu'une marche suppl�mentaire vers mon ascension au sommet..."),
                new Dialog(Enemies[0], "ALLEZ ! AM�NES-TOI !"),
                new Dialog(Enemies[0], "Viens te faire embrocher � nouveau... RITTEEEEEEEEEEEEEER !"),
                new Dialog(Heroes[2], "Choisis un dieu... et pries-le, ton heure a sonn�e... KRIEGEEEEEEEEEEEEER !"),

            };
            DialogsAfter = new List<Dialog>{
                new Dialog(Enemies[0], "Tu... Tu es devenu fort Ritter�"),
                new Dialog(Heroes[0], "Il .. Il a ... Il a encore l'�nergie pour parler ?!"),
                new Dialog(Heroes[1], "Visiblement..."),
                new Dialog(Heroes[2], "Maintenant parle Krieger ! Pourquoi fais-tu tout cela ?!"),
                new Dialog(Enemies[0], "Kof...kof..."),
                new Dialog(Enemies[0], "Ce pr�tre... avec le signe sur sa t�te ... b�ni par le dieu de ce monde ..."),
                new Dialog(Enemies[0], "PAR QUEL M�RITE A-T-IL RE�U UN TEL POUVOIR ?!"),
                new Dialog(Enemies[0], "Et cette mage exasp�rante..."),
                new Dialog(Enemies[0], "QUI A D�CID� QU'ELLE NA�TRAIT AVEC UN TEL TALENT ?!"),
                new Dialog(Enemies[0], "HEIN ?! QUI ?!"),
                new Dialog(Enemies[0], "Et puis toi Ritter..."),
                new Dialog(Enemies[0], "Jeune prodige ... Exemplaire depuis ton plus jeune �ge..."),
                new Dialog(Enemies[0], "Vous ne m�ritez pas d'�tre aussi g�t�s par la nature !"),
                new Dialog(Heroes[2], "Qu'est ce que tu racontes, on a travaill� dur pour en arriver l� !"),
                new Dialog(Enemies[0], "BALIVERNES ! Le destin vous a choy� depuis le d�part."),
                new Dialog(Enemies[0], "VOUS."),
                new Dialog(Enemies[0], "N'AVEZ."),
                new Dialog(Enemies[0], "M�RITE !"),
                new Dialog(Enemies[0], "Kof...kof..."),
                new Dialog(Heroes[0], "Garde ta salive, monstre..."),
                new Dialog(Heroes[1], "Nous devons en finir au plus vite !"),
                new Dialog(Heroes[2], "Pas encore... Je dois en savoir un peu plus sur ses r�elles ambitions..."),
                new Dialog(Enemies[0], "Mes vrais ambitions ?"),
                new Dialog(Enemies[0], "Ahah..."),
                new Dialog(Enemies[0], "C'est simple..."),
                new Dialog(Enemies[0], "DEVENIR UN DIEU VIVANT !"),
                new Dialog(Heroes[1], "C'est tout simplement impossible !"),
                new Dialog(Heroes[2], "PRetrouve la raison ! Tu d�lires Krieger !"),
                new Dialog(Enemies[0], "Les bandits pour capturer les �tres insignifiants..."),
                new Dialog(Enemies[0], "la sorci�re pour extraire leur �nergie vitale..."),
                new Dialog(Enemies[0], "Et moi..."),
                new Dialog(Enemies[0], "Pour me nourrir de toute leur essence !"),
                new Dialog(Heroes[1], "Cruaut� ! Blasph�mie ! ABJECTION !"),
                new Dialog(Heroes[0], "*Vomit*"),
                new Dialog(Heroes[2], "Magy !"),
                new Dialog(Heroes[1], "Vous ne pouvez pas recevoir ses �nergies vitales ! C'est... c'est contre les r�gles..."),
                new Dialog(Enemies[0], "Hm hm..."),
                new Dialog(Enemies[0], "Ah ah..."),
                new Dialog(Enemies[0], "AHAHAHAH !"),
                new Dialog(Enemies[0], "Celui qui fixe les r�gles..."),
                new Dialog(Enemies[0], "CE N'EST NUL AUTRE QUE MOI !"),



                new Dialog(Heroes[2], "QU'EST-CE QUI SE PASSE ?!"),
                new Dialog(Heroes[0], "Je .. je suis fatigu� .."),
                new Dialog(Heroes[1], "Sir Platz ?! O� �tes-vous ?!"),
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