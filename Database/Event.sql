
CREATE TABLE public."Event" (
    "Id" bigint NOT NULL,
    "Title" character varying(50) NOT NULL,
    "Description" character varying(1000) NOT NULL,
    "Picture" character varying(60),
    "Type" character varying(30),
    "Date" date
);


ALTER TABLE public."Event" OWNER TO postgres;

CREATE SEQUENCE public."Events_EventId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Events_EventId_seq" OWNER TO postgres;


ALTER SEQUENCE public."Events_EventId_seq" OWNED BY public."Event"."Id";


ALTER TABLE ONLY public."Event" ALTER COLUMN "Id" SET DEFAULT nextval('public."Events_EventId_seq"'::regclass);


--
-- TOC entry 2813 (class 0 OID 16569)
-- Dependencies: 199
-- Data for Name: Event; Type: TABLE DATA; Schema: public; Owner: postgres
--

insert into "Event" ("Id", "Title", "Description", "Picture", "Type", "Date") 
values
(4,	'Hip-Hop Night 11',	'"Hip-Hop Night" vam donosi samo najbolje od old school RnB i Rap glazbe, a ovoga puta smo ugostili cepinskog MC''a, NO ID, te vec dokazana imena na lokalnoj sceni, SRKI & IVI i NEISPAVANI!\nTINA KOKE ce imati svoj show u kojem ce nam pokazati kako izgleda ples pod imenom Dancehall, a TYFA BEATBOX ce jos jednom demonstrirati svoje umijece s mikrofonom u ruci.\nDJ MARUSHKA i ARMANDO ce im dati podrsku na gramofonima i pobrinuti se za odlicnu atmosferu na afteru, a MC Vedran Sokol iz Rap Skillza voditi cijeli program u svom osebujnom stilu, dodite i uzivajte!',	'assets/events/HipHopNight11.jpg'),
(1,	'Rap Skillz International',	'► RAP SKILLZ INTERNATIONAL ◀\n1 VS 1 A Cappella Written Rap Battles\n\t\t\t\n📅 Datum/Date: 02.09.2018. (Nedjelja/Sunday)\n\n📌 Lokacija/Location: Boogaloo, Zagreb, Avenija grada Vukovara 68\n\n🎤 Host: Vedran Sokol (CRO/Osijek)\n\n► BETLOVI/BATTLES\n\n♛ DIZASTER (CA/Los Angeles) vs RANDOM (CG/Podgorica)\n\n♛ KARIZMATIK (CRO/Vukovar) vs JANTAR (CRO/Ivanec)\n\n♛ VEB (SRB/Beograd) vs LEJDI LERDI (SRB/Beograd)\n\n♛ JURASICK (CRO/Ivanec) vs VENOK (BIH/Banja Luka)\n\n♛ PROST (SRB/Vršac) vs TRISPA (BIH/Sarajevo)\n\t\t\t\n► SATNICA/TIMETABLE\n18:00 h - 20:00 h Warm-up\n20:00 h - 23:30 h Battles\n23.30 h - 00:00 h Chill-out',	'assets/events/RapSkillzInternational1.jpg');


SELECT pg_catalog.setval('public."Events_EventId_seq"', 4, true);

ALTER TABLE ONLY public."Event"
    ADD CONSTRAINT "Events_pkey" PRIMARY KEY ("Id");