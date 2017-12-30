using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models
{
    public class ClientContext :DbContext
    {
        public ClientContext()
            : base("SqlConnection")
        {
            //Database.SetInitializer<ClientContext>(new CreateDatabaseIfNotExists<ClientContext>());

            //Database.SetInitializer<ClientContext>(new DropCreateDatabaseIfModelChanges<ClientContext>());
            //Database.SetInitializer<ClientContext>(new DropCreateDatabaseAlways<ClientContext>());
            Database.SetInitializer<ClientContext>(new ClientDbInitializer());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Ailment> Ailments { get; set; }
    }

    public class ClientDbInitializer : DropCreateDatabaseAlways<ClientContext>
    {
        protected override void Seed(ClientContext context)
        {
            //Seed Clients
            var clients = new List<Client>
            {
                new Client() {FirstName = "NoOne", LastName = "InParticular", Birthday = new DateTime(1980, 1, 1), Gender = Client.GenderEnum.Female}
            };
            

            var poorResistance = new Ailment() { Desc = "Poor Resistance to Colds & Flu" };
            var fatigue = new Ailment() { Desc = "Fatigue, tire easily" };
            var headaches = new Ailment() { Desc = "Frequent Headaches" };
            var memoryLoss = new Ailment() { Desc = "Memory Loss" };
            var anemia = new Ailment() { Desc = "Anemia" };
            var insomnia = new Ailment() { Desc = "Insomnia" };
            var prematureGraying = new Ailment() { Desc = "Premature Graying" };
            var hairLoss = new Ailment() { Desc = "Hair Loss" };
            var irritability = new Ailment() { Desc = "Irritability, Depression" };
            var underweight = new Ailment() { Desc = "Underweight" };
            var menopausal = new Ailment() { Desc = "Menopausal Problems" };
            var pms = new Ailment() { Desc = "PMS" };
            var constipation = new Ailment() { Desc = "Constipation" };
            var badBreath = new Ailment() { Desc = "Bad Breath" };
            var poorCirculation = new Ailment() { Desc = "Poor Circulation" };
            var bloodClots = new Ailment() { Desc = "Blood Clots, Phlebitis" };
            var highCholesterol = new Ailment() { Desc = "High Cholesterol" };
            var highBloodPressure = new Ailment() { Desc = "High Blood Pressure" };
            var highTriglycerides = new Ailment() { Desc = "High Triglycerides" };
            var prematureAging = new Ailment() { Desc = "Premature Aging" };
            var freedomOfMotion = new Ailment() { Desc = "Freedom of Motion Problems" };
            var sinus = new Ailment() { Desc = "Sinus Problems" };
            var allergies = new Ailment() { Desc = "Allergies, Hay Fever, Asthma" };
            var diarrhea = new Ailment() { Desc = "Diarrhea, Colitis" };
            var noseBleeds = new Ailment() { Desc = "Frequent Nose Bleeds" };
            var bruise = new Ailment() { Desc = "Bruise Easily" };
            var autoimmune = new Ailment() { Desc = "Autoimmune Disease" };

            var overweight = new Ailment() { Desc = "Overweight by more than 10lbs" };
            var varicose = new Ailment() { Desc = "Varicose Veins" };
            var badSkin = new Ailment() { Desc = "Bad Skin, Acne, Dull Lifeless Skin" };
            var yeast = new Ailment() { Desc = "Yeast Infections or Problems" };
            var sugar = new Ailment() { Desc = "Sugar or Carbohydrate Cravings" };
            var pain = new Ailment() { Desc = "Pain" };
            var viralInfections = new Ailment() { Desc = "Viral Infections" };
            var gallstones = new Ailment() { Desc = "Gallstones, Kidney Stones" };
            var bleedingGums = new Ailment() { Desc = "Bleeding Gums" };
            var nervous = new Ailment() { Desc = "Nervous Disorders" };
            var hemorrhoids = new Ailment() { Desc = "Hemorrhoids" };
            var poorDigestion = new Ailment() { Desc = "Poor Digestion - Gas, Bloating, Heartburn" };
            var porousBones = new Ailment() { Desc = "Porous Bones, Spontaneous Fractures" };
            var arthritis = new Ailment() { Desc = "Arthritis" };
            var menstrualCramps = new Ailment() { Desc = "Menstrual Cramps & Problems" };
            var cancer = new Ailment() { Desc = "Cancer" };
            var diabetes = new Ailment() { Desc = "Diabetes" };
            var nails = new Ailment() { Desc = "Nails - soft, splitting, white spots" };
            var smoker = new Ailment() { Desc = "Smoker" };
            var retainFluids = new Ailment() { Desc = "Retain Fluids" };
            var highStress = new Ailment() { Desc = "High Stress Lifestyle" };
            var slowRecovery = new Ailment() { Desc = "Slow Recovery of Wounds or Illness" };
            var coldHands = new Ailment() { Desc = "Cold Hands, Feet" };
            var muscleTension = new Ailment() { Desc = "Muscle Tension or Cramping" };
            var drySkin = new Ailment() { Desc = "Dry, Rough Skin" };
            var antibiotics = new Ailment() { Desc = "Frequent use of Antibiotics" };


            //Seed Ailments
            var ailments = new List<Ailment>
            {
                poorResistance,
                fatigue,
                headaches,
                memoryLoss,
                anemia,
                insomnia,
                prematureGraying,
                hairLoss,
                irritability,
                underweight,
                menopausal,
                pms,
                constipation,
                badBreath,
                poorCirculation,
                bloodClots,
                highCholesterol,
                highBloodPressure,
                highTriglycerides,
                prematureAging,
                freedomOfMotion,
                sinus,
                allergies,
                diarrhea,
                noseBleeds,
                bruise,
                autoimmune,
                overweight,
                varicose,
                badSkin,
                yeast,
                sugar,
                pain,
                viralInfections,
                gallstones,
                bleedingGums,
                nervous,
                hemorrhoids,
                poorDigestion,
                porousBones,
                arthritis,
                menstrualCramps,
                cancer,
                diabetes,
                nails,
                smoker,
                retainFluids,
                highStress,
                slowRecovery,
                coldHands,
                muscleTension,
                drySkin,
                antibiotics
            };
            
            var b = new Solution() { Desc = "B" };
            var c = new Solution() { Desc = "C" };
            var e = new Solution() { Desc = "E" };
            var cartomax = new Solution() { Desc = "Carotomax" };
            var coQHeart = new Solution() { Desc = "CoQHeart" };
            var omega3 = new Solution() { Desc = "Omega 3, EPA (OmegaGuard)" };
            var optiflora = new Solution() { Desc = "Optiflora" };
            var alfalfa = new Solution() { Desc = "Alfalfa Complex" };
            var calMag = new Solution() { Desc = "Cal/Mag (Osteomatrix)" };
            var cholesterol = new Solution() { Desc = "Cholesterol Regulation Complex" };
            var corEnergy = new Solution() { Desc = "CorEnergy" };
            var defendAndResist = new Solution() { Desc = "Defend & Resist Complex" };
            var dtx = new Solution() { Desc = "DTX (Liver DTX Complex)" };
            var ezGest = new Solution() { Desc = "EZ Gest" };
            var fiber = new Solution() { Desc = "Fiber" };
            var flavomax = new Solution() { Desc = "Flavomax" };
            var garlic = new Solution() { Desc = "Garlic Complex" };
            var gentleSleep = new Solution() { Desc = "Gentle Sleep Complex" };
            var gla = new Solution() { Desc = "GLA Complex" };
            var grc = new Solution() { Desc = "GRC (Glucose Regulation Complex)" };
            var herbLax = new Solution() { Desc = "Herb-lax" };
            var immuneIbc = new Solution() { Desc = "Immune IBC (Nutriferon)" };
            var immunityFormula = new Solution() { Desc = "Immunity Formula I" };
            var iron = new Solution() { Desc = "Iron (Iron Plus C Complex)" };
            var jointHealth = new Solution() { Desc = "Joint Health Complex" };
            var lecithin = new Solution() { Desc = "Lecithin" };
            var menopauseBalance = new Solution() { Desc = "Menopause Balance Complex" };
            var mentalAcuity = new Solution() { Desc = "Mental Acuity Plus" };
            var moodlift = new Solution() { Desc = "Moodlift Complex" };
            var painRelief = new Solution() { Desc = "Pain Relief Complex" };
            var protein = new Solution() { Desc = "Protein, Soy (Shaklee 180/Energizing Soy Protein)" };
            var stomachSoothing = new Solution() { Desc = "Stomach Soothing Complex" };
            var stressRelief = new Solution() { Desc = "Stress Relief Complex" };
            var zinc = new Solution() { Desc = "Zinc Complex" };
            var d3 = new Solution() { Desc = "Vitamin D3" };
            var vivix = new Solution() { Desc = "Vivix" };

            //Seed Solutions
            var solutions = new List<Solution>
            {
                b,
                c,
                e,
                cartomax,
                coQHeart,
                omega3,
                optiflora,
                alfalfa,
                calMag,
                cholesterol,
                corEnergy,
                defendAndResist,
                dtx,
                ezGest,
                fiber,
                flavomax,
                garlic,
                gentleSleep,
                gla,
                grc,
                herbLax,
                immuneIbc,
                immunityFormula,
                iron,
                jointHealth,
                lecithin,
                menopauseBalance,
                mentalAcuity,
                moodlift,
                painRelief,
                protein,
                stomachSoothing,
                stressRelief,
                zinc,
                d3,
                vivix
            };


            //Poor Resistance to Colds & Flus
            AddSolutionToAilment(poorResistance, immuneIbc);
            AddSolutionToAilment(poorResistance, cartomax);
            AddSolutionToAilment(poorResistance, c);
            AddSolutionToAilment(poorResistance, garlic);
            AddSolutionToAilment(poorResistance, defendAndResist);
            AddSolutionToAilment(poorResistance, optiflora);
            AddSolutionToAilment(poorResistance, immunityFormula);

            //Fatigue
            //AddSolutionToAilment(fatigue, soy + fiber);
            AddSolutionToAilment(fatigue, protein);
            AddSolutionToAilment(fatigue, fiber);
            AddSolutionToAilment(fatigue, b);
            AddSolutionToAilment(fatigue, corEnergy);
            AddSolutionToAilment(fatigue, grc);
            AddSolutionToAilment(fatigue, dtx);
            AddSolutionToAilment(fatigue, coQHeart);

            //Frequent Headaches
            AddSolutionToAilment(headaches, b);
            AddSolutionToAilment(headaches, c);
            AddSolutionToAilment(headaches, calMag);
            //AddSolutionToAilment(headaches, protein+fiber);
            AddSolutionToAilment(headaches, protein);
            AddSolutionToAilment(headaches, fiber);
            AddSolutionToAilment(headaches, herbLax);
            AddSolutionToAilment(headaches, gentleSleep);
            AddSolutionToAilment(headaches, gla);
            AddSolutionToAilment(headaches, grc);
            AddSolutionToAilment(headaches, dtx);

            //Memory Loss
            AddSolutionToAilment(memoryLoss, mentalAcuity);
            AddSolutionToAilment(memoryLoss, b);
            AddSolutionToAilment(memoryLoss, lecithin);
            //AddSolutionToAilment(memoryLoss, soy+fiber);
            AddSolutionToAilment(memoryLoss, protein);
            AddSolutionToAilment(memoryLoss, fiber);
            AddSolutionToAilment(memoryLoss, herbLax);

            //Anemia
            AddSolutionToAilment(anemia, immunityFormula);
            AddSolutionToAilment(anemia, protein);
            AddSolutionToAilment(anemia, iron);
            AddSolutionToAilment(anemia, c);

            //Insomnia
            AddSolutionToAilment(insomnia, b); //before 6pm
            AddSolutionToAilment(insomnia, calMag);
            AddSolutionToAilment(insomnia, grc);
            AddSolutionToAilment(insomnia, gentleSleep);
            AddSolutionToAilment(insomnia, moodlift);
            AddSolutionToAilment(insomnia, stressRelief);

            //Premature Graying
            AddSolutionToAilment(prematureGraying, b);
            AddSolutionToAilment(prematureGraying, zinc);
            AddSolutionToAilment(prematureGraying, garlic);

            //Hair Loss
            //AddSolutionToAilment(hairLoss, protein+fiber);
            AddSolutionToAilment(hairLoss, protein);
            AddSolutionToAilment(hairLoss, fiber);
            AddSolutionToAilment(hairLoss, b);
            AddSolutionToAilment(hairLoss, zinc);
            AddSolutionToAilment(hairLoss, gla);
            AddSolutionToAilment(hairLoss, dtx);
            AddSolutionToAilment(hairLoss, mentalAcuity);
            AddSolutionToAilment(hairLoss, e);

            //irratibility
            AddSolutionToAilment(irritability, b);
            AddSolutionToAilment(irritability, c);
            AddSolutionToAilment(irritability, calMag);
            //AddSolutionToAilment(irritability, protein+fiber);
            AddSolutionToAilment(irritability, protein);
            AddSolutionToAilment(irritability, fiber);
            AddSolutionToAilment(irritability, grc);
            AddSolutionToAilment(irritability, stressRelief);
            AddSolutionToAilment(irritability, gla);
            AddSolutionToAilment(irritability, moodlift);
            AddSolutionToAilment(irritability, gentleSleep);

            //underweight
            AddSolutionToAilment(underweight, b);
            AddSolutionToAilment(underweight, c);
            //AddSolutionToAilment(underweight, soy+fiber);
            AddSolutionToAilment(underweight, protein);
            AddSolutionToAilment(underweight, fiber);
            AddSolutionToAilment(underweight, corEnergy);

            //Menopausal Problems
            AddSolutionToAilment(menopausal, b);
            AddSolutionToAilment(menopausal, e);
            //AddSolutionToAilment(menopausal, EPA);
            AddSolutionToAilment(menopausal, calMag);
            AddSolutionToAilment(menopausal, protein); //soy
            AddSolutionToAilment(menopausal, moodlift);
            AddSolutionToAilment(menopausal, menopauseBalance);
            AddSolutionToAilment(menopausal, gla);
            //AddSolutionToAilment(menopausal, Progesterone Cr);
            AddSolutionToAilment(menopausal, gentleSleep);

            //PMS
            AddSolutionToAilment(pms, b);
            AddSolutionToAilment(pms, e);
            AddSolutionToAilment(pms, gla);
            AddSolutionToAilment(pms, protein);//soy
            AddSolutionToAilment(pms, alfalfa);
            AddSolutionToAilment(pms, moodlift);
            //AddSolutionToAilment(pms, Progesterone Cream);
            AddSolutionToAilment(pms, dtx);
            AddSolutionToAilment(pms, c);

            //Constipation
            AddSolutionToAilment(constipation, herbLax);
            AddSolutionToAilment(constipation, fiber);
            AddSolutionToAilment(constipation, ezGest);
            AddSolutionToAilment(constipation, alfalfa);
            AddSolutionToAilment(constipation, c);
            AddSolutionToAilment(constipation, stomachSoothing);
            AddSolutionToAilment(constipation, optiflora);

            //Bad Breath
            AddSolutionToAilment(badBreath, herbLax);
            AddSolutionToAilment(badBreath, fiber);
            AddSolutionToAilment(badBreath, alfalfa);
            AddSolutionToAilment(badBreath, optiflora);
            AddSolutionToAilment(badBreath, ezGest);

            //Poor Circulation
            AddSolutionToAilment(poorCirculation, mentalAcuity);
            AddSolutionToAilment(poorCirculation, e);
            AddSolutionToAilment(poorCirculation, b);
            AddSolutionToAilment(poorCirculation, c);
            AddSolutionToAilment(poorCirculation, lecithin);
            AddSolutionToAilment(poorCirculation, coQHeart);
            AddSolutionToAilment(poorCirculation, omega3);

            //Blood Clots
            AddSolutionToAilment(bloodClots, e);
            AddSolutionToAilment(bloodClots, c);
            AddSolutionToAilment(bloodClots, calMag);
            AddSolutionToAilment(bloodClots, omega3);
            AddSolutionToAilment(bloodClots, lecithin);
            AddSolutionToAilment(bloodClots, mentalAcuity);
            AddSolutionToAilment(bloodClots, coQHeart);

            //High Cholesterol
            AddSolutionToAilment(highCholesterol, garlic);
            AddSolutionToAilment(highCholesterol, lecithin);
            AddSolutionToAilment(highCholesterol, c);
            AddSolutionToAilment(highCholesterol, fiber);
            AddSolutionToAilment(highCholesterol, e);
            AddSolutionToAilment(highCholesterol, omega3);
            AddSolutionToAilment(highCholesterol, protein); //soy
            AddSolutionToAilment(highCholesterol, coQHeart);
            AddSolutionToAilment(highCholesterol, stressRelief);
            AddSolutionToAilment(highCholesterol, cholesterol);


            //High Blood Pressure
            AddSolutionToAilment(highBloodPressure, garlic);
            AddSolutionToAilment(highBloodPressure, e);
            AddSolutionToAilment(highBloodPressure, lecithin);
            AddSolutionToAilment(highBloodPressure, omega3);
            AddSolutionToAilment(highBloodPressure, calMag);
            AddSolutionToAilment(highBloodPressure, gentleSleep);
            AddSolutionToAilment(highBloodPressure, mentalAcuity);
            AddSolutionToAilment(highBloodPressure, coQHeart);

            //High Triglycerides
            AddSolutionToAilment(highTriglycerides, garlic);
            AddSolutionToAilment(highTriglycerides, lecithin);
            AddSolutionToAilment(highTriglycerides, c);
            AddSolutionToAilment(highTriglycerides, fiber); //Fiber Plan
            AddSolutionToAilment(highTriglycerides, e);
            AddSolutionToAilment(highTriglycerides, omega3);
            AddSolutionToAilment(highTriglycerides, coQHeart);
            AddSolutionToAilment(highTriglycerides, stressRelief);
            AddSolutionToAilment(highTriglycerides, protein); //soy

            //Premature Aging
            AddSolutionToAilment(prematureAging, e);
            AddSolutionToAilment(prematureAging, cartomax);
            AddSolutionToAilment(prematureAging, c);
            AddSolutionToAilment(prematureAging, immuneIbc);
            AddSolutionToAilment(prematureAging, zinc);
            AddSolutionToAilment(prematureAging, mentalAcuity);
            AddSolutionToAilment(prematureAging, stressRelief);

            //Freedom of Motion Problems
            AddSolutionToAilment(freedomOfMotion, jointHealth);
            AddSolutionToAilment(freedomOfMotion, alfalfa);
            AddSolutionToAilment(freedomOfMotion, c);

            //Sinus Problems
            AddSolutionToAilment(sinus, immuneIbc); //immune building complex
            AddSolutionToAilment(sinus, cartomax);
            AddSolutionToAilment(sinus, alfalfa);
            AddSolutionToAilment(sinus, c);
            AddSolutionToAilment(sinus, garlic);

            //Allergies
            AddSolutionToAilment(allergies, immuneIbc);
            AddSolutionToAilment(allergies, alfalfa);
            AddSolutionToAilment(allergies, garlic);
            AddSolutionToAilment(allergies, c);
            AddSolutionToAilment(allergies, cartomax);
            AddSolutionToAilment(allergies, gla);

            //diarrhea
            AddSolutionToAilment(diarrhea, optiflora);
            AddSolutionToAilment(diarrhea, garlic);
            AddSolutionToAilment(diarrhea, c);
            AddSolutionToAilment(diarrhea, b);
            AddSolutionToAilment(diarrhea, stomachSoothing);

            //Nose Bleeds
            AddSolutionToAilment(noseBleeds, c);

            //bruise easily
            AddSolutionToAilment(bruise, c);
            AddSolutionToAilment(bruise, lecithin);
            AddSolutionToAilment(bruise, mentalAcuity);

            //Autoimmune disease
            AddSolutionToAilment(autoimmune, coQHeart);
            AddSolutionToAilment(autoimmune, c);
            AddSolutionToAilment(autoimmune, e);
            AddSolutionToAilment(autoimmune, cartomax);
            AddSolutionToAilment(autoimmune, zinc);
            AddSolutionToAilment(autoimmune, optiflora);
            AddSolutionToAilment(autoimmune, garlic);
            AddSolutionToAilment(autoimmune, stressRelief);

            //Overweight
            //AddSolutionToAilment(overweight, Slim Plan Gold);
            AddSolutionToAilment(overweight, b);
            AddSolutionToAilment(overweight, c);
            AddSolutionToAilment(overweight, lecithin);
            AddSolutionToAilment(overweight, gla);
            AddSolutionToAilment(overweight, jointHealth);
            AddSolutionToAilment(overweight, grc);
            AddSolutionToAilment(overweight, stressRelief);

            //varicose
            AddSolutionToAilment(varicose, e);
            AddSolutionToAilment(varicose, c);

            //Bad skin
            AddSolutionToAilment(badSkin, garlic);
            AddSolutionToAilment(badSkin, cartomax);
            AddSolutionToAilment(badSkin, c);
            AddSolutionToAilment(badSkin, e);
            AddSolutionToAilment(badSkin, zinc);
            AddSolutionToAilment(badSkin, b);
            AddSolutionToAilment(badSkin, herbLax);
            AddSolutionToAilment(badSkin, fiber);
            AddSolutionToAilment(badSkin, gla);
            AddSolutionToAilment(badSkin, dtx);

            //Yeast Infections
            AddSolutionToAilment(yeast, c);
            AddSolutionToAilment(yeast, b);
            AddSolutionToAilment(yeast, garlic);
            AddSolutionToAilment(yeast, cartomax);
            AddSolutionToAilment(yeast, zinc);
            AddSolutionToAilment(yeast, optiflora);
            AddSolutionToAilment(yeast, dtx);

            //sugar cravings
            AddSolutionToAilment(sugar, grc);
            AddSolutionToAilment(sugar, b);
            AddSolutionToAilment(sugar, zinc);
            //AddSolutionToAilment(sugar, soy+fiber);
            AddSolutionToAilment(sugar, protein);
            AddSolutionToAilment(sugar, fiber);

            //pain
            AddSolutionToAilment(pain, painRelief);
            AddSolutionToAilment(pain, jointHealth);
            AddSolutionToAilment(pain, c);
            AddSolutionToAilment(pain, alfalfa);
            AddSolutionToAilment(pain, omega3);
            AddSolutionToAilment(pain, calMag);

            //Viral infections
            AddSolutionToAilment(viralInfections, garlic);
            AddSolutionToAilment(viralInfections, c);
            AddSolutionToAilment(viralInfections, zinc);
            AddSolutionToAilment(viralInfections, immuneIbc);
            AddSolutionToAilment(viralInfections, cartomax);
            AddSolutionToAilment(viralInfections, optiflora);
            AddSolutionToAilment(viralInfections, moodlift);
            AddSolutionToAilment(viralInfections, immunityFormula);
            AddSolutionToAilment(viralInfections, defendAndResist);
            AddSolutionToAilment(viralInfections, coQHeart);

            //gallstones
            AddSolutionToAilment(gallstones, herbLax);
            AddSolutionToAilment(gallstones, garlic);
            AddSolutionToAilment(gallstones, c);
            AddSolutionToAilment(gallstones, calMag);
            AddSolutionToAilment(gallstones, lecithin);
            AddSolutionToAilment(gallstones, ezGest);
            AddSolutionToAilment(gallstones, dtx);


            //Bleeding gums
            AddSolutionToAilment(bleedingGums, c);

            //nervous disorders
            AddSolutionToAilment(nervous, b);
            AddSolutionToAilment(nervous, calMag);
            AddSolutionToAilment(nervous, c);
            AddSolutionToAilment(nervous, e);
            AddSolutionToAilment(nervous, gentleSleep);
            AddSolutionToAilment(nervous, moodlift);
            AddSolutionToAilment(nervous, stressRelief);

            //Hemorrhoids
            AddSolutionToAilment(hemorrhoids, herbLax);
            AddSolutionToAilment(hemorrhoids, c);
            AddSolutionToAilment(hemorrhoids, fiber);
            AddSolutionToAilment(hemorrhoids, b);
            AddSolutionToAilment(hemorrhoids, optiflora);

            //poor digestion
            AddSolutionToAilment(poorDigestion, b);
            AddSolutionToAilment(poorDigestion, ezGest);
            AddSolutionToAilment(poorDigestion, dtx);
            AddSolutionToAilment(poorDigestion, stressRelief);
            AddSolutionToAilment(poorDigestion, alfalfa);
            AddSolutionToAilment(poorDigestion, optiflora);
            AddSolutionToAilment(poorDigestion, stomachSoothing);

            //Porous bones
            AddSolutionToAilment(porousBones, calMag);
            AddSolutionToAilment(porousBones, e);
            AddSolutionToAilment(porousBones, alfalfa);
            AddSolutionToAilment(porousBones, c);

            //arthritis
            AddSolutionToAilment(arthritis, jointHealth);
            AddSolutionToAilment(arthritis, painRelief);
            AddSolutionToAilment(arthritis, alfalfa);
            AddSolutionToAilment(arthritis, c);
            AddSolutionToAilment(arthritis, omega3);
            AddSolutionToAilment(arthritis, calMag);
            AddSolutionToAilment(arthritis, gla);
            AddSolutionToAilment(arthritis, stressRelief);

            //Menstrual cramps
            AddSolutionToAilment(menstrualCramps, e);
            AddSolutionToAilment(menstrualCramps, calMag);
            AddSolutionToAilment(menstrualCramps, b);
            //AddSolutionToAilment(menstrualCramps, EPA);
            AddSolutionToAilment(menstrualCramps, stomachSoothing);
            AddSolutionToAilment(menstrualCramps, gentleSleep);
            AddSolutionToAilment(menstrualCramps, gla);

            //Cancer
            AddSolutionToAilment(cancer, e);
            AddSolutionToAilment(cancer, cartomax);
            AddSolutionToAilment(cancer, zinc);
            AddSolutionToAilment(cancer, immuneIbc);
            AddSolutionToAilment(cancer, garlic);
            AddSolutionToAilment(cancer, gla);
            AddSolutionToAilment(cancer, defendAndResist);
            AddSolutionToAilment(cancer, dtx);
            AddSolutionToAilment(cancer, c);
            AddSolutionToAilment(cancer, coQHeart);
            AddSolutionToAilment(cancer, stressRelief);


            //Diabetes
            AddSolutionToAilment(diabetes, b);
            AddSolutionToAilment(diabetes, e);
            AddSolutionToAilment(diabetes, grc);
            AddSolutionToAilment(diabetes, zinc);
            AddSolutionToAilment(diabetes, c);
            AddSolutionToAilment(diabetes, cartomax);
            //AddSolutionToAilment(diabetes, protein+fiber);
            AddSolutionToAilment(diabetes, protein);
            AddSolutionToAilment(diabetes, fiber);
            AddSolutionToAilment(diabetes, gla);

            //Nails
            //AddSolutionToAilment(nails, soy+fiber);
            AddSolutionToAilment(nails, protein);
            AddSolutionToAilment(nails, fiber);
            AddSolutionToAilment(nails, zinc);
            AddSolutionToAilment(nails, calMag);
            AddSolutionToAilment(nails, gla);

            //smoker
            AddSolutionToAilment(smoker, c);
            AddSolutionToAilment(smoker, b);
            AddSolutionToAilment(smoker, cartomax);
            AddSolutionToAilment(smoker, e);
            AddSolutionToAilment(smoker, immuneIbc);
            AddSolutionToAilment(smoker, stressRelief);

            //retain fluids
            AddSolutionToAilment(retainFluids, alfalfa);
            AddSolutionToAilment(retainFluids, b);
            AddSolutionToAilment(retainFluids, c);
            AddSolutionToAilment(retainFluids, moodlift);
            AddSolutionToAilment(retainFluids, dtx);

            //high stress
            AddSolutionToAilment(highStress, b);
            AddSolutionToAilment(highStress, stressRelief);
            AddSolutionToAilment(highStress, c);
            AddSolutionToAilment(highStress, calMag);
            AddSolutionToAilment(highStress, corEnergy);
            AddSolutionToAilment(highStress, gentleSleep);
            AddSolutionToAilment(highStress, zinc);

            //slow recovery
            AddSolutionToAilment(slowRecovery, zinc);
            AddSolutionToAilment(slowRecovery, e);
            //AddSolutionToAilment(slowRecovery, soy+fiber);
            AddSolutionToAilment(slowRecovery, protein);
            AddSolutionToAilment(slowRecovery, fiber);
            AddSolutionToAilment(slowRecovery, defendAndResist);
            AddSolutionToAilment(slowRecovery, gla);

            //cold hands
            AddSolutionToAilment(coldHands, e);
            AddSolutionToAilment(coldHands, lecithin);
            AddSolutionToAilment(coldHands, omega3);
            AddSolutionToAilment(coldHands, c);
            AddSolutionToAilment(coldHands, mentalAcuity);
            AddSolutionToAilment(coldHands, coQHeart);

            //muscle tension
            AddSolutionToAilment(muscleTension, calMag);
            AddSolutionToAilment(muscleTension, alfalfa);
            AddSolutionToAilment(muscleTension, b);
            AddSolutionToAilment(muscleTension, stressRelief);
            AddSolutionToAilment(muscleTension, gentleSleep);

            //Dry skin
            AddSolutionToAilment(drySkin, e);
            AddSolutionToAilment(drySkin, zinc);
            AddSolutionToAilment(drySkin, cartomax);
            AddSolutionToAilment(drySkin, c);
            AddSolutionToAilment(drySkin, omega3);
            AddSolutionToAilment(drySkin, gla);
            AddSolutionToAilment(drySkin, lecithin);

            //antibiotics
            AddSolutionToAilment(antibiotics, optiflora);
            AddSolutionToAilment(antibiotics, immuneIbc);
            AddSolutionToAilment(antibiotics, c);
            AddSolutionToAilment(antibiotics, garlic);
            AddSolutionToAilment(antibiotics, cartomax);
            AddSolutionToAilment(antibiotics, protein); //soy
            AddSolutionToAilment(antibiotics, e);

            foreach (var client in clients)
            {
                context.Clients.Add(client);
            }

            foreach (var ailment in ailments)
            {
                context.Ailments.Add(ailment);
            }

            foreach (var solution in solutions)
            {
                context.Solutions.Add(solution);
            }

            context.SaveChanges();

            base.Seed(context);
        }

        private void AddSolutionToAilment(Ailment ailment, Solution solution)
        {
            if (!ailment.Solutions.Contains(solution))
            {
                ailment.Solutions.Add(solution);   
            }
            if (!solution.Ailments.Contains(ailment))
            {
                solution.Ailments.Add(ailment);   
            }
        }
    }
}