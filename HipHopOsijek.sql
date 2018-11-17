--
-- PostgreSQL database dump
--

-- Dumped from database version 10.4
-- Dumped by pg_dump version 10.5

-- Started on 2018-11-17 14:02:31

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 1 (class 3079 OID 12924)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2844 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


--
-- TOC entry 213 (class 1255 OID 16445)
-- Name: SetDate(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."SetDate"() RETURNS trigger
    LANGUAGE plpgsql STABLE
    AS $$begin
NEW."DateCreated" := NOW();
RETURN NEW;
END;
$$;


ALTER FUNCTION public."SetDate"() OWNER TO postgres;

--
-- TOC entry 216 (class 1255 OID 16449)
-- Name: UpdateDate(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."UpdateDate"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
NEW."LastModifyDate" := NOW();
RETURN NEW;
END;
$$;


ALTER FUNCTION public."UpdateDate"() OWNER TO postgres;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 197 (class 1259 OID 16530)
-- Name: Comment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Comment" (
    "Id" bigint NOT NULL,
    "EventId" bigint NOT NULL,
    "Text" character varying(1000),
    "PersonId" bigint NOT NULL
);


ALTER TABLE public."Comment" OWNER TO postgres;

--
-- TOC entry 196 (class 1259 OID 16528)
-- Name: Comment_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Comment_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Comment_Id_seq" OWNER TO postgres;

--
-- TOC entry 2845 (class 0 OID 0)
-- Dependencies: 196
-- Name: Comment_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Comment_Id_seq" OWNED BY public."Comment"."Id";


--
-- TOC entry 199 (class 1259 OID 16569)
-- Name: Event; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Event" (
    "Id" bigint NOT NULL,
    "Title" character varying(50) NOT NULL,
    "Description" character varying(1000) NOT NULL,
    "Picture" character varying(60),
    "Type" character varying(30),
    "Date" date
);


ALTER TABLE public."Event" OWNER TO postgres;

--
-- TOC entry 201 (class 1259 OID 24798)
-- Name: EventUser; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."EventUser" (
    "Id" bigint NOT NULL,
    "EventId" bigint NOT NULL,
    "PersonId" bigint NOT NULL
);


ALTER TABLE public."EventUser" OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 16567)
-- Name: Events_EventId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Events_EventId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Events_EventId_seq" OWNER TO postgres;

--
-- TOC entry 2846 (class 0 OID 0)
-- Dependencies: 198
-- Name: Events_EventId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Events_EventId_seq" OWNED BY public."Event"."Id";


--
-- TOC entry 202 (class 1259 OID 24847)
-- Name: Guest; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Guest" (
    "Id" bigint NOT NULL,
    "Name" character varying(50) NOT NULL,
    "Description" character varying(1000) NOT NULL,
    "Picture" character varying(100)
);


ALTER TABLE public."Guest" OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 24788)
-- Name: Person; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Person" (
    "Id" bigint NOT NULL,
    "Name" character varying(20) NOT NULL,
    "Surname" character varying(20) NOT NULL,
    "Email" character varying(50) NOT NULL,
    "Password" character varying(24) NOT NULL,
    "Status" boolean
);


ALTER TABLE public."Person" OWNER TO postgres;

--
-- TOC entry 2693 (class 2604 OID 16533)
-- Name: Comment Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Comment" ALTER COLUMN "Id" SET DEFAULT nextval('public."Comment_Id_seq"'::regclass);


--
-- TOC entry 2694 (class 2604 OID 16572)
-- Name: Event Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Event" ALTER COLUMN "Id" SET DEFAULT nextval('public."Events_EventId_seq"'::regclass);


--
-- TOC entry 2831 (class 0 OID 16530)
-- Dependencies: 197
-- Data for Name: Comment; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Comment" ("Id", "EventId", "Text", "PersonId") FROM stdin;
\.


--
-- TOC entry 2833 (class 0 OID 16569)
-- Dependencies: 199
-- Data for Name: Event; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Event" ("Id", "Title", "Description", "Picture", "Type", "Date") FROM stdin;
4	Hip-Hop Night 11	"Hip-Hop Night" vam donosi samo najbolje od old school RnB i Rap glazbe, a ovoga puta smo ugostili cepinskog MC'a, NO ID, te vec dokazana imena na lokalnoj sceni, SRKI & IVI i NEISPAVANI!\nTINA KOKE ce imati svoj show u kojem ce nam pokazati kako izgleda ples pod imenom Dancehall, a TYFA BEATBOX ce jos jednom demonstrirati svoje umijece s mikrofonom u ruci.\nDJ MARUSHKA i ARMANDO ce im dati podrsku na gramofonima i pobrinuti se za odlicnu atmosferu na afteru, a MC Vedran Sokol iz Rap Skillza voditi cijeli program u svom osebujnom stilu, dodite i uzivajte!	assets/events/HipHopNight11.jpg	\N	\N
1	Rap Skillz International	► RAP SKILLZ INTERNATIONAL ◀\n1 VS 1 A Cappella Written Rap Battles\n\t\t\t\n📅 Datum/Date: 02.09.2018. (Nedjelja/Sunday)\n\n📌 Lokacija/Location: Boogaloo, Zagreb, Avenija grada Vukovara 68\n\n🎤 Host: Vedran Sokol (CRO/Osijek)\n\n► BETLOVI/BATTLES\n\n♛ DIZASTER (CA/Los Angeles) vs RANDOM (CG/Podgorica)\n\n♛ KARIZMATIK (CRO/Vukovar) vs JANTAR (CRO/Ivanec)\n\n♛ VEB (SRB/Beograd) vs LEJDI LERDI (SRB/Beograd)\n\n♛ JURASICK (CRO/Ivanec) vs VENOK (BIH/Banja Luka)\n\n♛ PROST (SRB/Vršac) vs TRISPA (BIH/Sarajevo)\n\t\t\t\n► SATNICA/TIMETABLE\n18:00 h - 20:00 h Warm-up\n20:00 h - 23:30 h Battles\n23.30 h - 00:00 h Chill-out	assets/events/RapSkillzInternational1.jpg	\N	\N
\.


--
-- TOC entry 2835 (class 0 OID 24798)
-- Dependencies: 201
-- Data for Name: EventUser; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."EventUser" ("Id", "EventId", "PersonId") FROM stdin;
\.


--
-- TOC entry 2836 (class 0 OID 24847)
-- Dependencies: 202
-- Data for Name: Guest; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Guest" ("Id", "Name", "Description", "Picture") FROM stdin;
1	Vedran Sokol	Malo nesta o njemu tu da pise cisto radi reda.	assets/guests/vedran.png
\.


--
-- TOC entry 2834 (class 0 OID 24788)
-- Dependencies: 200
-- Data for Name: Person; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Person" ("Id", "Name", "Surname", "Email", "Password", "Status") FROM stdin;
\.


--
-- TOC entry 2847 (class 0 OID 0)
-- Dependencies: 196
-- Name: Comment_Id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Comment_Id_seq"', 1, false);


--
-- TOC entry 2848 (class 0 OID 0)
-- Dependencies: 198
-- Name: Events_EventId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Events_EventId_seq"', 4, true);


--
-- TOC entry 2696 (class 2606 OID 16538)
-- Name: Comment Comment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Comment"
    ADD CONSTRAINT "Comment_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 2702 (class 2606 OID 24802)
-- Name: EventUser EventUser_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."EventUser"
    ADD CONSTRAINT "EventUser_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 2698 (class 2606 OID 16577)
-- Name: Event Events_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Event"
    ADD CONSTRAINT "Events_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 2700 (class 2606 OID 24792)
-- Name: Person Person_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Person"
    ADD CONSTRAINT "Person_pkey" PRIMARY KEY ("Id");


--
-- TOC entry 2704 (class 2606 OID 24854)
-- Name: Guest guest_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Guest"
    ADD CONSTRAINT guest_pkey PRIMARY KEY ("Id");


--
-- TOC entry 2705 (class 2606 OID 16580)
-- Name: Comment Comment_EventId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Comment"
    ADD CONSTRAINT "Comment_EventId_fkey" FOREIGN KEY ("EventId") REFERENCES public."Event"("Id");


--
-- TOC entry 2706 (class 2606 OID 24793)
-- Name: Comment Comment_PersonId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Comment"
    ADD CONSTRAINT "Comment_PersonId_fkey" FOREIGN KEY ("PersonId") REFERENCES public."Person"("Id");


--
-- TOC entry 2707 (class 2606 OID 24803)
-- Name: EventUser EventUser_EventId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."EventUser"
    ADD CONSTRAINT "EventUser_EventId_fkey" FOREIGN KEY ("EventId") REFERENCES public."Event"("Id");


--
-- TOC entry 2708 (class 2606 OID 24808)
-- Name: EventUser EventUser_PersonId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."EventUser"
    ADD CONSTRAINT "EventUser_PersonId_fkey" FOREIGN KEY ("PersonId") REFERENCES public."Person"("Id");


-- Completed on 2018-11-17 14:02:31

--
-- PostgreSQL database dump complete
--

