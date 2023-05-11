using DP_NFS.photoalbum;
using System;

namespace DP_NFS {
    class Program {
        static void Main(string[] args) {
            Album myAlbum = new Album();

            // je veux ajouter 2 photos et un commentaire dans myAlbum
            // Je veux aussi créer un autre album avec 1 photo et 1 commentaire et l'ajouter à myAlbum

            myAlbum.Add(new Photo("toto.jpg", "la tête de Toto"));
            myAlbum.Add(new Photo("titi.jpg", "la tête de Titi"));
            myAlbum.Add(new Comment("Les têtes de mes potos"));
            Album subAlbum = new Album();
            subAlbum.Add(new Photo("nana.jpg", "la tête de Nana"));
            subAlbum.Add(new Comment("Les têtes de mes ex"));
            myAlbum.Add(subAlbum);
        }
    }
}
