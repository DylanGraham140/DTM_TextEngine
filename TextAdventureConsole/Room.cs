using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureConsole {
    class Room {
        private string name;
        private int length;
        private int width;
        private bool hasNorthDoor;
        private bool hasEastDoor;
        private bool hasSouthDoor;
        private bool hasWestDoor;
        private things[]; 

        public Room(string nm, int len, int wid) {
            name = nm;
            length = len;
            width = wid;
        } //end constructor

        // Properties for setting and getting
        // values of class variables.
        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        } //end name property
       
        public int Length {
            get {
                return length;
            }
            set {
                length = value;
            }
        } //end length property

        public int Width {
            get {
                return width;
            }
            set {
                width = value;
            }
        } //end width property

        public bool HasNorthDoor {
            get {
                return hasNorthDoor;
            }

            set {
                hasNorthDoor = value;
            }
        } //end hasNorthDoor property

        public bool HasEastDoor {
            get {
                return hasEastDoor;
            }

            set {
                hasEastDoor = value;
            }
        } //end hasEastDoor property

        public bool HasSouthDoor {
            get {
                return hasSouthDoor;
            }

            set {
                hasSouthDoor = value;
            }
        } //end hasSouthDoor property

        public bool HasWestDoor {
            get {
                return hasWestDoor;
            }

            set {
                hasWestDoor = value;
            }
        } //end hasWestDoor property

    } //end class
} //end namespace
