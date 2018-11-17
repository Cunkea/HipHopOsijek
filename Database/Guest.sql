
CREATE TABLE public."Guest" (
    "Id" bigint NOT NULL,
    "Name" character varying(50) NOT NULL,
    "Description" character varying(1000) NOT NULL,
    "Picture" character varying(100)
);


ALTER TABLE public."Guest" OWNER TO postgres;

--
-- TOC entry 2811 (class 0 OID 24847)
-- Dependencies: 202
-- Data for Name: Guest; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Guest" ("Id", "Name", "Description", "Picture") FROM stdin;
(1,	'Vedran Sokol',	'Malo nesta o njemu tu da pise cisto radi reda.',	'assets/guests/vedran.png')

ALTER TABLE ONLY public."Guest"
    ADD CONSTRAINT guest_pkey PRIMARY KEY ("Id");