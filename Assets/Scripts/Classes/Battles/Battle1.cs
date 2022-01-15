using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle1 : Battle
    {
        public Battle1() :base() {}

        public override void FillScene()
        {
            
            //Background = Resources.Load<Sprite>("Sprites/Background/bg_foret");
            Background = "Forest";
            Music = "music-1";
            DialogsBefore = new List<Dialog>{
                new Dialog(Heroes[2], "Et donc Runden, tu dis que c'est dans cette for�t que se terre le chef des bandits ?"),
                new Dialog(Heroes[1], "Je ne suis pas \"s�r\", mais je pense que c'est une hypoth�se � v�rifier oui."),
                new Dialog(Heroes[2], "Dans ce cas l� restons sur nos gardes..."),
                new Dialog(Heroes[0], "Dis Runden, je me suis toujours demand�..."),
                new Dialog(Heroes[0], "C'est quoi cette marque sur ton front au juste ?"),
                new Dialog(Heroes[1], "Ah �a...?"),
                new Dialog(Heroes[1], "On l'appelle la \"marque divine\". Elle est apparue lorsque j'ai re�u la b�n�diction."),
                new Dialog(Heroes[1], "Notre Dieu m'a jug� pur, et par cons�quent j'ai h�rit� de pouvoirs de gu�rison."),
                new Dialog(Heroes[0], "Ok, je vois !"),
                new Dialog(Heroes[0], "*Dans sa t�te* �a fait bizarre d'avoir sur le front.. mais �a donne un style..."),
                new Dialog(Heroes[0], "M'enfin bon, rien ne vaut la bonne vieille lecture de sorts magiques en combat !"),
                new Dialog(Heroes[1], "C'est vrai que je ne poss�de pas tes �tranges pouvoirs."),
                new Dialog(Heroes[0], "Je pourrais te montrer encore quelques sorts si tu veux."),
                new Dialog(Heroes[2], "Magy ! Runden ! Silence..."),
                new Dialog(Heroes[2], "...Je sens une pr�sence..."),
                new Dialog(Heroes[1], "Vous �tes s�rs messire Platz...?"),
                new Dialog(Heroes[0], "Ce n'est s�rement qu'un anim-"),
                new Dialog(new EnemyUnknown(), "Dans ces lieux il n'y a qu'une seule fa�on de voir le monde."),
                new Dialog(new EnemyUnknown(), "�tre le pr�dateur..."),
                new Dialog(new EnemyUnknown(), "...Ou la proie."),
                new Dialog(Heroes[2], "Hmm."),
                new Dialog(Heroes[2], "C'est donc bien toi ce fameux Roi des Bandits dont tout le monde parle tant ?"),


                new Dialog(Enemies[0], "Ooooh... Ma r�putation me pr�c�de donc ? Tant d'honneurs..."),
                new Dialog(Enemies[0], "Tiens mais ! Je le reconnais ce chauve !"),
                new Dialog(Enemies[0], "Ahahahah, je me souviendrais encore des cris de d�tresse que poussaient ses petits cadets le couteau sous la gorge !"),
                new Dialog(Heroes[0], "Runden ? De quoi parle-t-il ?"),
                new Dialog(Enemies[0], "Il dormait comme un mort ! Ahahahah !"),
                new Dialog(Heroes[1], "..."),
                new Dialog(Heroes[1], "Il y a quelques ann�es, mes fr�res et soeurs ont �t� captur�s par un groupe de pilleurs..."),
                new Dialog(Heroes[1], "Pendant ma fameuse b�n�diction .."),
                new Dialog(Heroes[0], "Comment �a tu dormais ?"),
                new Dialog(Heroes[1], "Tu �tais donc derri�re tout �a ?!"),
                new Dialog(Heroes[2], "Ne gaspille pas ta salive pour cette crapule Runden, il n'en vaut pas la peine."),
                new Dialog(Heroes[2], "Le seul moyen de lui rendre la monnaie de sa pi�ce c'est de rendre justice."),
                new Dialog(Heroes[2], "En garde, vaurien... Ton heure a sonn� !"),
                new Dialog(Heroes[0], "Heu.. oui.. OUI ! Ahah !"),
                new Dialog(Enemies[0], "AHAHAH ! Essayez donc pour voir !"),
            };
            DialogsAfter= new List<Dialog>{
                new Dialog(Heroes[0], "Wahahah ! C'�tait trop facile !"),
                new Dialog(Heroes[0], "Enfin je crois..."),
                new Dialog(Heroes[1], "Magy ! S'il te pla�t, il rend son dernier souffle..."),
                new Dialog(Heroes[2], "Voil� une bonne chose de faite. Tu repensera � deux fois � tes m�faits."),
                new Dialog(Heroes[2], "Maintenant dis-nous tout ce que tu sais, m�cr�ant."),
                new Dialog(Enemies[0], "Je ... hurgh .. je ne sais rien du tout... du moins je ne m'en souviens plus.."),
                new Dialog(Enemies[0], "Urgh .. keuf .. keuf ."),
                new Dialog(Heroes[2], "Fais vite !"),
                new Dialog(Heroes[1], "Patience Messire, il y vient..."),
            };
        }
        public override void FillEnemies()
        {
            Enemies.Add(new Enemy1());
        }
    }
}