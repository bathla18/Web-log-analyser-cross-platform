

DEBUG?= -g
CFLAGS?= -O2 -Wall -W
CCOPT= $(CFLAGS)

OBJ = wsla.o aht.o antigetopt.o tail.o
PRGNAME = wsla

all: wsla

wsla.o: wsla.c blacklist.h
wsla: $(OBJ)
	$(CC) -o $(PRGNAME) $(CCOPT) $(DEBUG) $(OBJ)

.c.o:
	$(CC) -c $(CCOPT) $(DEBUG) $(COMPILE_TIME) $<

clean:
	rm -rf $(PRGNAME) *.o
