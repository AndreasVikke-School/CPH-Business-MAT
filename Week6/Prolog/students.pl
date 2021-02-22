student(andreas).
student(william).
student(martin).
student(asger).

study(dbd).
study(dsc).
study(mal).
study(ufo).

room(200).
room(201).
room(202).
room(203).

date(1502).
date(1602).
date(1702).
date(1802).
date(1902).

class(mal, 1502, 200, andreas).
class(dsc, 1602, 201, andreas).
class(dbd, 1702, 202, andreas).
class(dbd, 1802, 203, andreas).
class(ufo, 1902, 201, andreas).
class(mal, 1502, 200, william).
class(dsc, 1602, 201, william).
class(dbd, 1702, 202, william).
class(dbd, 1802, 203, william).
class(ufo, 1902, 201, william).
class(mal, 1502, 200, martin).
class(dbd, 1702, 202, martin).
class(dbd, 1802, 203, martin).
class(ufo, 1902, 201, martin).
class(mal, 1502, 200, asger).
class(dbd, 1702, 202, asger).
class(dbd, 1802, 203, asger).
class(ufo, 1902, 201, asger).

classOnDate(Date, Student, Room, Study) :-
    student(Student),
    date(Date),
    room(Room),
    study(Study),
    class(Study, Date, Room, Student).