namespace GetRandomWordAPI.Service;

public class DataService
{
    public List<string> wordlist = new List<string>()
    {
        "exsanguinating", "douse", "brunizems", "pentose", "melding", "unended", "cooeyed", "barrelful", "cans",
        "schoolmate", "cactoid", "podesta", "hernia", "prefunds", "sociologeses", "disvalued", "faithlessly",
        "punitivenesses", "simmered", "orthopsychiatry", "pullbacks", "nights", "tendon", "maladapted", "hymeneal",
        "tubulous", "ultrarich", "polygene", "petahertz", "reboots", "ferromagnetism", "hillslopes", "definers",
        "fluxions", "fecials", "fastening", "charqui", "valonia", "watchfulness", "muzzles", "materfamiliases",
        "raspinesses", "washed", "merchanting", "permittivity", "aquas", "sonders", "gentile", "unsuitable",
        "bilocations", "nonpaid", "carbaryl", "miscopied", "protonematal", "hairbands", "encina", "rakehells", "famed",
        "antitobacco", "patricidal", "radioecology", "atheistically", "crankcase", "cymbidia", "jessamine", "hymens",
        "hocused", "leftism", "closetful", "desultorily", "sternutation", "nonconsolidated", "maderizes", "tentacled",
        "hoofer", "saporous", "ricercars", "praams", "bisulfates", "comprized", "gamin", "pickerels", "promines",
        "countercampaign", "oblates", "airfreighting", "traceless", "solemn", "evicting", "manifoldnesses",
        "amalgamation", "exalting", "taupes", "gasted", "bailey", "vocationalisms", "aphoristic", "expiators",
        "camisoles", "beatify", "homothallism", "microeconomics", "shirtsleeve", "equilibrium", "overweary",
        "richweeds", "botflies", "leverage", "wharfmaster", "lagomorphs", "gleds", "scirrhuses", "bunt", "rootlet",
        "phenyl", "pyroxylins", "queues", "unthread", "orgasmic", "abstruser", "gogglers", "stroma", "noncontributory",
        "dendrological", "replications", "sensitivenesses", "pyroxylin", "fountains", "spectroscopists", "vrooms",
        "contorts", "pimas", "clanking", "saiga", "iconological", "futzes", "touchups", "amnions", "scintilla",
        "driegh", "bombs", "vault", "perduring", "draffs", "unununiums", "noncolorfast", "provenances", "sacral",
        "heroes", "tacitness", "overbuilds", "speak", "vitamers", "cannulas", "skep", "peepshows", "clam", "swampier",
        "primed", "stonecrop", "tougher", "desuetudes", "archegoniate", "sentimentalized", "dittoing", "personnels",
        "grubworm", "paintball", "semicentennials", "choline", "evading", "vigorously", "brants", "flaccidly",
        "regicidal", "pertinacity", "scribbles", "composted", "artistries", "equilibrant", "salaryman", "grahams",
        "backwashing", "aero", "splined", "starfruit", "dazzlingly", "nocturnal", "antidemocratic", "outdress",
        "responsory", "xerophthalmic", "despotic", "ngultrums", "permafrosts", "killed", "clasps", "prebilled",
        "heedless", "biers", "suffrages", "carp", "rid", "offered", "speedways", "remediabilities", "hydrogels",
        "responsum", "longneck", "menshes", "dipsomaniac", "undersell", "defused", "ranch", "tyre", "pressmen",
        "introspecting", "scallopinis", "catastrophism", "refluence", "stiffer", "passivated", "profuseness", "divers",
        "rearmice", "canid", "stalemate", "retainer", "zirams", "walrus", "sandstones", "mousepads", "admiringly",
        "mustinesses", "fatsoes", "zouaves", "grenadier", "intenerate", "postworkshop", "deaminizing", "pannier",
        "paupered", "cunningly", "hijra", "sandsoaps", "postboxes", "antiplague", "overswings", "plot", "lawed",
        "adultery", "decerning", "haggles", "practicability", "gallicisms", "citrus", "deceptiveness", "unciae",
        "acclimations", "streamed", "sojourners", "polymerisations", "brioches", "remunerate", "hoarfrosts", "candours",
        "ordurous", "cryoprotectant", "effective", "fanes", "domic", "emendators", "prating", "cossets", "dossil",
        "cronyism", "syrinxes", "jiggliest", "nickelodeon", "cumbersomely", "ruttishly", "ironwoods", "thromboses",
        "statistically", "protyle", "bullae", "stooping", "cervid", "simpleness", "credibly", "chimpanzee", "rackety",
        "logarithms", "myxomycetes", "polyzoan", "nonnutritive", "baiting", "anoopsia", "parallax", "prejudge",
        "electroscope", "bynames", "usurpers", "exhausters", "moderated", "birled", "exited", "ineluctability",
        "decagon", "yelling", "repotting", "manorialism", "orishas", "sculping", "sunups", "summaries", "mammas",
        "paperer", "recidivism", "temptress", "moonlit", "externalisation", "thoroughbreds", "bombing", "specificity",
        "numerological", "squarishness", "inceptives", "homestretch", "volatiles", "harboring", "overprotecting",
        "rectorial", "lookalikes", "hepatomas", "terylenes", "overhandling", "wiry", "cowbird", "convex", "dan",
        "advice", "caption", "myriopod", "journalizes", "intimacies", "gauche", "tootled", "riveter", "twirl", "boas",
        "paralysis", "college", "identicalness", "gestalten", "longies", "storyboarding", "morello", "photopositive",
        "detestableness", "loamless", "backsets", "pumicing", "sutler", "overfatigue", "epoxies", "flutist", "skittery",
        "tasse", "unweave", "hacking", "robotries", "chased", "thegn", "layabouts", "stereoisomers", "eyelet",
        "spackles", "nucleators", "bankabilities", "ebullitions", "agio", "deliverer", "disentitles", "sawbones",
        "decontaminating", "koumysses", "actins", "bullishly", "unelectable", "instantaneity", "shippings", "baccarat",
        "copulates", "primulas", "foscarnet", "diolefin", "credibilities", "phytotoxicities", "corpulencies",
        "revoices", "bolds", "wincer", "unornate", "respreading", "warden", "poussetted", "botchers", "monochromist",
        "goiters", "oroides", "sanger", "cuddly", "pupilage", "mikes", "obviates", "reek", "reluctancies", "pipits",
        "shinleaves", "rightsize", "nonspeakers", "nonnarrative", "feoffors", "preeminence", "morons", "ort",
        "rattlebrained", "carder", "ka", "indene", "adjurer", "outlaid", "doubtfulness", "visual", "bimbette", "momi",
        "superseding", "hillside", "chlorides", "veterinarians", "braciolas", "laserdisc", "brotherlinesses",
        "unbudging", "papains", "postdoctorate", "trailerite", "purlin", "enterocoele", "bent", "unmanly", "ruinous",
        "sloth", "nancies", "cointer", "linebreeding", "vaulting", "misfeasances", "cartwheeled", "interdictory",
        "mixible", "stationeries", "repartition", "oxysalt", "traitress", "saturnalia", "stemmer", "evenhandedness",
        "taxers", "noumenal", "ochred", "rhamnuses", "anthropical", "rufiyaa", "overinforms", "rachial", "restlessness",
        "stupid", "flagrance", "volcanism", "hypocotyl", "wangle", "jaculating", "unproduced", "scamsters",
        "clapboards", "bedframe", "diphosgenes", "rivulets", "electrotonic", "sarongs", "explicits", "proctologies",
        "instrumentalism", "casern", "tuille", "paralysed", "twains", "quipped", "eloigners", "hempier", "chivalric",
        "grummeted", "kilted", "pandoras", "muspike", "vacuoles", "speedster", "riantly", "strigil", "undergraduate",
        "caved", "slackeners", "tamburs", "monocotyledon", "slideways", "cyclicality", "vivacities", "tearily",
        "lambasts", "cruets", "dittoed", "deviates", "banzai", "ixoras", "sarcomatous", "immunocompetent",
        "supervirtuosi", "bolas", "blanking", "spoilt", "semiautomatic", "satyrid", "collectanea", "layovers",
        "liturgist", "crudding", "intercommunity", "lingual", "garrisons", "genial", "aquifers", "lean", "warsles",
        "scandalised", "morosity", "clergies", "grimily", "autogiro", "nitromethane", "uropodal", "multistate",
        "folkmots", "beclogged", "customising", "embanking", "hardtop", "factorize", "yashmak", "stockholders",
        "parriers", "anlages", "sixteen", "nephridium", "deponing", "redeveloper", "mirexes", "macrocytosis", "rumaki",
        "bimesters", "solar", "swathed", "grugrus", "paraquets", "radioactive", "badgerly", "nymphetic", "theelols",
        "goldenrods", "tenanting", "hard", "sedition", "fillable", "quitted", "ywis", "infamously", "clansman",
        "softie", "ailurophobe", "nonsciences", "oxpecker", "sufficers", "kinsmen", "oysters", "omnipresent",
        "lightens", "stifles", "upcoast", "expostulated", "instrumentation", "tyees", "courthouse", "hacklier",
        "myoelectric", "philtering", "shields", "ethnographical", "baksheeshes", "algometers", "recutting", "trichoid",
        "persisters", "annoyers", "skirret", "rhizoplane", "betterments", "revolutionizing", "diminishing",
        "grandnephew", "thornbushes", "gaucho", "monovular", "whipped", "dip", "monsignorial", "strand", "rereviewing",
        "fanciless", "butterless", "psittacosis", "crossover", "wears", "resecting", "cornhusking", "musted",
        "worriting", "jambeaux", "rejoinder", "killingly", "hazardous", "swashbuckler", "lingcod", "flaunts", "munnion",
        "obliterates", "federating", "boardsailor", "cichlids", "rudimentary", "translocates", "chitties",
        "inanimatenesses", "allotropy", "founders", "shivs", "gynecocracies", "bookoos", "scrummages", "differential",
        "alveolate", "crimine", "ovoli", "portraiture", "boulevard", "provascular", "retributive", "sycophantly",
        "loobies", "hanked", "overwearing", "glorifications", "cinematheques", "antiquation", "embezzles", "modillion",
        "verbiles", "setscrews", "gestical", "enthrones", "kinswoman", "puparium", "tutu", "blindgut", "loudness",
        "circularities", "comments", "transparency", "culinarily", "squishiest", "lubbers", "reunify", "pastoriums",
        "stupefy", "rubble", "annealers", "belletristic", "traceabilities", "canula", "stannaries", "wellsprings",
        "repumping", "microscopy", "choiring", "woodsmen", "ungroomed", "biathlon", "tunableness", "terne", "brownnose",
        "delicates", "solidifies", "lonenesses", "supplementer", "belted", "spotlighting", "nonaffiliated", "aposporic",
        "retrodictive", "ramulous", "moveables", "millcake", "keelless", "vomiters", "danders", "wackier", "toothless",
        "digenetic", "prolonging", "masterstrokes", "determining", "midsole", "publishing", "razeed", "shrewishnesses",
        "quickset", "hackies", "stardom", "oncogenicities", "syphs", "moly", "zoologist", "intervenor", "cholecyst",
        "repeopling", "stickups", "forechecker", "kickboxers", "ransacks", "homeopathies", "postfeminist", "triliths",
        "carvers", "endergonic", "nonbook", "riverboat", "tercentennial", "skaldic", "hyperstimulates",
        "discouragingly", "belonged", "incompatibility", "electable", "semiological", "spirulae", "nonlogical",
        "openest", "localise", "torridness", "adularias", "hornblende", "umbered", "burnishers", "droughtiest",
        "chalkboards", "parcloses", "strafing", "triter", "inbreedings", "juvenals", "sop", "halloo", "right",
        "campers", "diademing", "omen", "enroll", "grassplot", "topstone", "concertgoers", "paralyzed", "spoonsful",
        "chlorosis", "nondemand", "bungled", "pill", "outsit", "surmising", "fitly", "junkers", "embow", "lobbyisms",
        "stolons", "girliest", "scoleces", "shortest", "tattooers", "cassaba", "barbule", "mistimed", "shadows",
        "conscience", "particularize", "goniffs", "unhumorous", "fluorins", "mode", "carcinogenicity", "unfroze",
        "acerbate", "sextains", "onrushes", "gnawers", "humorless", "praetorians", "enfeoffing", "gamic", "constable",
        "symphonies", "timed", "sulfones", "freemasonries", "faxed", "subacidnesses", "resplendent", "cade",
        "feuilletonism", "gimped", "figuring", "aphanite", "maenades", "trawlnets", "gallowglass", "engenders",
        "humidify", "isoglosses", "pinpricked", "inflation", "kirigamis", "veniality", "perches", "eloined", "weeklong",
        "slalom", "hingers", "theatrical", "novenae", "noticeably", "favouring", "fardels", "rephotographs",
        "skepticism", "vigilances", "drippily", "detoured", "cemeteries", "immedicably", "henbit", "caprock", "seders",
        "accessorises", "gripey", "cruciate", "recti", "meridian", "bullshitting", "tergiversator", "disproval",
        "easements", "klaxon", "amnesic", "linac", "dissembled", "pilsners", "cornichon", "tangrams", "miming",
        "tweedling", "tetanizations", "drastic", "anlas", "kief", "hypnagogic", "gyrations", "discolored", "medullas",
        "rereviewed", "blockading", "presageful", "airlift", "plecopterans", "embonpoint", "pula", "hesitater",
        "mealies", "suggester", "frillier", "worldbeats", "overwarm", "ozonation", "currency", "grubstake",
        "tendrilous", "miocene", "nausea", "clawers", "gaols", "craniotomy", "metabolisms", "anuses", "refiner",
        "spreader", "imperativeness", "slaveholders", "formulaically", "shabbiness", "warrantableness", "harbingered",
        "kickboxed", "mitres", "gunnings", "tarot", "plunk", "bedder", "phrenitides", "lamsters", "bloodfins",
        "dogtrotting", "tuggers", "moviemakings", "kinkajous", "crudest", "boonies", "lionized", "gleyed",
        "microbursts", "magnificoes", "torquate", "kiltie", "fun", "mithridates", "tatamis", "errable", "fulminant",
        "firewood", "postfire", "quibbled", "quarantine", "chucklingly", "vitrectomy", "lending", "paintworks",
        "maledictions", "ganger", "nonprosses", "eliminative", "lobbygows", "cycles", "nogging", "greenbriers",
        "unembittered", "monocyte", "hideousness", "crenelles", "osteopathic", "kindheartedly", "distaffs", "pyrostat",
        "drawnwork", "oesophagi", "blossom", "descriptive", "analogical", "imbibes", "ogre", "flyblow", "filmy",
        "greenstones", "bands", "minas", "pommels", "chanced", "cobby", "refired", "razzmatazzes", "repowers",
        "officiants", "pyrolas", "scrive", "temperamental"
    };
    
}
