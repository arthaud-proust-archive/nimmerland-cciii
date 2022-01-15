using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle2 : Battle
    {
        public Battle2() : base() { }

        public override void FillScene()
        {

            //Background = Resources.Load<Sprite>("Sprites/Background/bg_foret");
            Background = "Desert";
            Music = "music-2";
            DialogsBefore = new List<Dialog>{
                new Dialog(Heroes[0], "Pfff... Je d�teste ce d�sert..."),
                new Dialog(Heroes[2], "Parler n'arrangera pas les choses."),
                new Dialog(Heroes[0], "�a va, �a va, pas la peine d'�tre aussi rabat-joie."),
                new Dialog(Heroes[0], "Ah si vous saviez comment je hais cette r�gion..."),
                new Dialog(Heroes[0], "Les scorpions, les grains de sable br�lants, et ce soleil �touffant."),
                new Dialog(Heroes[0], "Et c'est sans compter la Pr�tresse du Soleil..."),
                new Dialog(Heroes[1], "Hein ?"),
                new Dialog(Heroes[1], "La quoi ?"),
                new Dialog(Heroes[0], "Comment �a ? Tu n'as jamais entendu parler de la Pr�tresse du Soleil le clerc ?"),
                new Dialog(Heroes[2], "Ne te meprends pas Runden, ce n'est pas une r�elle pr�tresse comme toi."),
                new Dialog(Heroes[2], "En r�alit� c'est plus une sorci�re qu'autre chose."),
                new Dialog(Heroes[2], "On raconte qu'elle charme les voyageurs faibles d'esprits venant s'aventurer dans le d�sert."),
                new Dialog(Heroes[2], "Et par une �trange magie elle leur aspire leur vitalit� feu � feu."),
                new Dialog(Heroes[1], "Qu'est-ce encore que cette l�gende urbaine rocambolesque ?!"),
                new Dialog(Heroes[2], "Tu as bien raison, ce genre d'histoire est pittoresque�"),
                new Dialog(Heroes[0], "Moi j'y crois."),
                new Dialog(Heroes[2], "Hum ? Plait-il ?"),
                new Dialog(Heroes[0], "Voyez-vous, mon grand-fr�re �tait chevalier comme messire Platz. C'�tait mon mod�le."),
                new Dialog(Heroes[0], "Sa derni�re destination connue n'�tait autre que  le d�sert de Gelebewuste dans la m�me direction que nous."),
                new Dialog(Heroes[2], "Et donc...?"),
                new Dialog(Heroes[0], "Mon fr�re �tait un grand guerrier invaincu, enfin pour son �ge."),
                new Dialog(Heroes[0], "Je suis pr�t � parier qu'il s'est fait avoir par cette Pr�tresse ridicule."),
                new Dialog(Heroes[0], "Il n'est jamais revenu de son voyage, elle l'a tu� ! C'est s�r !"),
                new Dialog(Heroes[1], "Calmez-vous Lady Dreieck, la chaleur commence � avoir raison de vous. Tenez un peu d'eau."),
                new Dialog(Heroes[0], "GlouGlouGlou... aaaahhh, un vrai soigneur, je vous remercie.."),
                new Dialog(Heroes[0], "Cependant arr�tez de m'appeller \"Lady\" ! Kirchlich. Je ne suis en rien comme mes parents..."),
                new Dialog(Heroes[0], "Et non je sais ce que je dis."),
                new Dialog(Heroes[1], "Toutes mes excuses, Lad- euh Magy."),
                new Dialog(Heroes[0], "Hehehe, vous voyez quand vous voulez !"),
                new Dialog(Heroes[2], "Tsss, dans tous les cas c'est tout simplement une histoire � dormir debout."),
                new Dialog(Heroes[2], "Alors un peu de s�rieux et continuons d�av-..."),
                new Dialog(new EnemyUnknown(this), "Qu'entends-je ? Qu�ou�s-je ? Une histoire � dormir debout ?"),
                new Dialog(Heroes[2], "HM ?!"),



                new Dialog(Heroes[0], "C'EST ELLE ! C'EST LA PR�TRESSE DU SOLEIL !"),
                new Dialog(Enemies[0], "En effet je suis bien celle que vous pr�tendez.", true),
                new Dialog(Enemies[0], "Oh, ce regard que vous avez-l�, il me rappelle celui d'un chevalier..."),
                new Dialog(Enemies[0], "Quel �tait son nom d�j�...?"),
                new Dialog(Enemies[0], "Oh, apr�s tout peu d'importance, il n'a pas surv�cu longtemps apr�s avoir succomb� � mon charme..."),
                new Dialog(Heroes[0], "SALE RIBAUDE ! Tout est de ta faute !"),
                new Dialog(Heroes[0], "TU AS TU� MON FR�RE !"),
                new Dialog(Heroes[2], "Bien, vrai ou non, cette femme ne me revient pas."),
                new Dialog(Heroes[2], "Aux armes."),
                new Dialog(Heroes[1], "Nous allons lui montrer qu'il ne faut pas salir le nom des Pr�tres !"),
                new Dialog(Heroes[0], "C'est une sorci�re Kirchlich !"),
                new Dialog(Heroes[1], "Ah ? Ah !"),
                new Dialog(Heroes[1], "Dans ce cas emp�chons l� d'embellir les tristes contes sur les sorci�res."),
                new Dialog(Enemies[0], "Coooommeeent ?"),
                new Dialog(Enemies[0], "Vous pensez s�rieusement avoir une chance contre moi ?"),
                new Dialog(Enemies[0], "Comme c�est mignon�"),
                new Dialog(Enemies[0], "Tr�s bien, dans ce cas je ne vais pas me retenir !"),
                new Dialog(Heroes[2], "Cause cause, tu ne perds rien pour attendre cuistre !"),


            };
            DialogsAfter = new List<Dialog>{
                new Dialog(Heroes[2], "Voil� une bonne chose de faite."),
                new Dialog(Heroes[0], "..."),
                new Dialog(Heroes[1], "Lady Dr...Euh, Magy. Tout va bien ?"),
                new Dialog(Heroes[0], "J-Je... Je ne sais pas trop..."),
                new Dialog(Heroes[0], "J'ai beau avoir veng� l'�me de mon fr�re, je ressens tout de m�me un certain vide en moi."),
                new Dialog(Heroes[2], "C'est normal. Elle aspirait notre vie.. mais ce n�est pas tout�"),
                new Dialog(Heroes[0], "Qu�entendez-vous par l� ?"),
                new Dialog(Heroes[2], "Venger votre fr�re devait probablement �tre votre plus grand d�sir."),
                new Dialog(Heroes[2], "Et vous venez tout juste de le faire en tuant cette maudite sorci�re."),
                new Dialog(Heroes[2], "Seulement voil�, maintenant que vous �tes arriv�e au sommet de la liste de vos priorit�s..."),
                new Dialog(Heroes[2], "Et bien, c'est comme si vous n'en aviez plus aucune."),
                new Dialog(Heroes[0], "Je..."),
                new Dialog(Heroes[1], "Et bieeeen... On ne dirait pas comme �a, mais vous �tes plut�t philosophique au fond messire."),
                new Dialog(Heroes[2], "�pargne moi ton sarcasme Kirchlich, contente toi de nous garder en vie comme tu sais le faire."),
                new Dialog(Heroes[2], "Notre prochaine destination n'est autre que Blauerberg. Je ne sais pas r�ellement ce qui nous y attends, mais�"),
                new Dialog(Enemies[0], "AAAAAAAAAHHHH !"),
                new Dialog(Enemies[0], "QUAND VOUS SEREZ L�-BAS !"),
                new Dialog(Enemies[0], "IL ME VENGERA ! !"),
                new Dialog(Enemies[0], "SEIGNEUR SCHW�. !"),
                new Dialog(Heroes[0], "Quel odieux personnage� Mais bon au moins elle est morte pour de bon."),
                new Dialog(Heroes[1], "Vous disiez messire ?"),
                new Dialog(Heroes[2], "Tes sorts de soin vont nous �tre utiles. D�p�chons-nous."),
            };
        }
        public override void FillEnemies()
        {
            Enemies.Add(new Enemy2(this));
        }
    }
}