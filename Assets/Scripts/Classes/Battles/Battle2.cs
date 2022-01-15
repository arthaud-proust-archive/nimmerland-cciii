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
                new Dialog(Heroes[0], "Pfff... Je déteste ce désert..."),
                new Dialog(Heroes[2], "Parler n'arrangera pas les choses."),
                new Dialog(Heroes[0], "Ça va, ça va, pas la peine d'être aussi rabat-joie."),
                new Dialog(Heroes[0], "Ah si vous saviez comment je hais cette région..."),
                new Dialog(Heroes[0], "Les scorpions, les grains de sable brûlants, et ce soleil étouffant."),
                new Dialog(Heroes[0], "Et c'est sans compter la Prêtresse du Soleil..."),
                new Dialog(Heroes[1], "Hein ?"),
                new Dialog(Heroes[1], "La quoi ?"),
                new Dialog(Heroes[0], "Comment ça ? Tu n'as jamais entendu parler de la Prêtresse du Soleil le clerc ?"),
                new Dialog(Heroes[2], "Ne te meprends pas Runden, ce n'est pas une réelle prêtresse comme toi."),
                new Dialog(Heroes[2], "En réalité c'est plus une sorcière qu'autre chose."),
                new Dialog(Heroes[2], "On raconte qu'elle charme les voyageurs faibles d'esprits venant s'aventurer dans le désert."),
                new Dialog(Heroes[2], "Et par une étrange magie elle leur aspire leur vitalité feu à feu."),
                new Dialog(Heroes[1], "Qu'est-ce encore que cette légende urbaine rocambolesque ?!"),
                new Dialog(Heroes[2], "Tu as bien raison, ce genre d'histoire est pittoresque…"),
                new Dialog(Heroes[0], "Moi j'y crois."),
                new Dialog(Heroes[2], "Hum ? Plait-il ?"),
                new Dialog(Heroes[0], "Voyez-vous, mon grand-frère était chevalier comme messire Platz. C'était mon modèle."),
                new Dialog(Heroes[0], "Sa dernière destination connue n'était autre que  le désert de Gelebewuste dans la même direction que nous."),
                new Dialog(Heroes[2], "Et donc...?"),
                new Dialog(Heroes[0], "Mon frère était un grand guerrier invaincu, enfin pour son âge."),
                new Dialog(Heroes[0], "Je suis prêt à parier qu'il s'est fait avoir par cette Prêtresse ridicule."),
                new Dialog(Heroes[0], "Il n'est jamais revenu de son voyage, elle l'a tué ! C'est sûr !"),
                new Dialog(Heroes[1], "Calmez-vous Lady Dreieck, la chaleur commence à avoir raison de vous. Tenez un peu d'eau."),
                new Dialog(Heroes[0], "GlouGlouGlou... aaaahhh, un vrai soigneur, je vous remercie.."),
                new Dialog(Heroes[0], "Cependant arrêtez de m'appeller \"Lady\" ! Kirchlich. Je ne suis en rien comme mes parents..."),
                new Dialog(Heroes[0], "Et non je sais ce que je dis."),
                new Dialog(Heroes[1], "Toutes mes excuses, Lad- euh Magy."),
                new Dialog(Heroes[0], "Hehehe, vous voyez quand vous voulez !"),
                new Dialog(Heroes[2], "Tsss, dans tous les cas c'est tout simplement une histoire à dormir debout."),
                new Dialog(Heroes[2], "Alors un peu de sérieux et continuons d’av-..."),
                new Dialog(new EnemyUnknown(this), "Qu'entends-je ? Qu’ouïs-je ? Une histoire à dormir debout ?"),
                new Dialog(Heroes[2], "HM ?!"),



                new Dialog(Heroes[0], "C'EST ELLE ! C'EST LA PRÊTRESSE DU SOLEIL !"),
                new Dialog(Enemies[0], "En effet je suis bien celle que vous prétendez.", true),
                new Dialog(Enemies[0], "Oh, ce regard que vous avez-là, il me rappelle celui d'un chevalier..."),
                new Dialog(Enemies[0], "Quel était son nom déjà...?"),
                new Dialog(Enemies[0], "Oh, après tout peu d'importance, il n'a pas survécu longtemps après avoir succombé à mon charme..."),
                new Dialog(Heroes[0], "SALE RIBAUDE ! Tout est de ta faute !"),
                new Dialog(Heroes[0], "TU AS TUÉ MON FRÈRE !"),
                new Dialog(Heroes[2], "Bien, vrai ou non, cette femme ne me revient pas."),
                new Dialog(Heroes[2], "Aux armes."),
                new Dialog(Heroes[1], "Nous allons lui montrer qu'il ne faut pas salir le nom des Prêtres !"),
                new Dialog(Heroes[0], "C'est une sorcière Kirchlich !"),
                new Dialog(Heroes[1], "Ah ? Ah !"),
                new Dialog(Heroes[1], "Dans ce cas empêchons là d'embellir les tristes contes sur les sorcières."),
                new Dialog(Enemies[0], "Coooommeeent ?"),
                new Dialog(Enemies[0], "Vous pensez sérieusement avoir une chance contre moi ?"),
                new Dialog(Enemies[0], "Comme c’est mignon…"),
                new Dialog(Enemies[0], "Très bien, dans ce cas je ne vais pas me retenir !"),
                new Dialog(Heroes[2], "Cause cause, tu ne perds rien pour attendre cuistre !"),


            };
            DialogsAfter = new List<Dialog>{
                new Dialog(Heroes[2], "Voilà une bonne chose de faite."),
                new Dialog(Heroes[0], "..."),
                new Dialog(Heroes[1], "Lady Dr...Euh, Magy. Tout va bien ?"),
                new Dialog(Heroes[0], "J-Je... Je ne sais pas trop..."),
                new Dialog(Heroes[0], "J'ai beau avoir vengé l'âme de mon frère, je ressens tout de même un certain vide en moi."),
                new Dialog(Heroes[2], "C'est normal. Elle aspirait notre vie.. mais ce n’est pas tout…"),
                new Dialog(Heroes[0], "Qu’entendez-vous par là ?"),
                new Dialog(Heroes[2], "Venger votre frère devait probablement être votre plus grand désir."),
                new Dialog(Heroes[2], "Et vous venez tout juste de le faire en tuant cette maudite sorcière."),
                new Dialog(Heroes[2], "Seulement voilà, maintenant que vous êtes arrivée au sommet de la liste de vos priorités..."),
                new Dialog(Heroes[2], "Et bien, c'est comme si vous n'en aviez plus aucune."),
                new Dialog(Heroes[0], "Je..."),
                new Dialog(Heroes[1], "Et bieeeen... On ne dirait pas comme ça, mais vous êtes plutôt philosophique au fond messire."),
                new Dialog(Heroes[2], "Épargne moi ton sarcasme Kirchlich, contente toi de nous garder en vie comme tu sais le faire."),
                new Dialog(Heroes[2], "Notre prochaine destination n'est autre que Blauerberg. Je ne sais pas réellement ce qui nous y attends, mais…"),
                new Dialog(Enemies[0], "AAAAAAAAAHHHH !"),
                new Dialog(Enemies[0], "QUAND VOUS SEREZ LÀ-BAS !"),
                new Dialog(Enemies[0], "IL ME VENGERA ! !"),
                new Dialog(Enemies[0], "SEIGNEUR SCHW…. !"),
                new Dialog(Heroes[0], "Quel odieux personnage… Mais bon au moins elle est morte pour de bon."),
                new Dialog(Heroes[1], "Vous disiez messire ?"),
                new Dialog(Heroes[2], "Tes sorts de soin vont nous être utiles. Dépêchons-nous."),
            };
        }
        public override void FillEnemies()
        {
            Enemies.Add(new Enemy2(this));
        }
    }
}