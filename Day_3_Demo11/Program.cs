namespace Day_3_Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory scf = new SpellCheckerFactory();
            ISpellChecker iobj = scf.GetSomeSpellChecker("fr");

            Notepad frnotepad = new Notepad(iobj);
            frnotepad.SpellCheck();

            Notepad ennotepad = new Notepad(null);
            ennotepad.SpellCheck();

            KlingonSpellchecker klsc = new KlingonSpellchecker();
            Notepad klnotepad = new Notepad(klsc);
            klnotepad.SpellCheck();

            HindiSpellchecker hsc = new HindiSpellchecker();
            Notepad hdnotepad = new Notepad(hsc);
            hdnotepad.SpellCheck();

        }
    }

    public class Notepad
    {
        ISpellChecker _checker = null;

        public Notepad(ISpellChecker checker)
        {
            if(checker == null)
            {
                _checker = new EnglishSpellChecker();
            }
            else
            {
                _checker = checker;
            }
        }

        public void Cut()
        {
            Console.WriteLine("Cut");
        }
        public void Copy()
        {
            Console.WriteLine("Copy");
        }
        public void Paste()
        {
            Console.WriteLine("Paste");
        }
        public void SpellCheck()
        {
            _checker.DoSpellChecker();
        }
    }

    public class SpellCheckerFactory
    {
        public ISpellChecker GetSomeSpellChecker(string lang)
        {
            ISpellChecker _somechecker = null;

            switch(lang)
            {
                case "en":
                    _somechecker = new EnglishSpellChecker();
                    break;
                case "fr":
                    _somechecker = new FrenchSpellchecker();
                    break;
                case "sp":
                    _somechecker = new SpanishSpellchecker();
                    break;
                default:
                    _somechecker = new EnglishSpellChecker();
                    break;
            }
            return _somechecker;
        }
    }

    public interface ISpellChecker
    {
        void DoSpellChecker();
    }

    public class EnglishSpellChecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check Done in English");
        }
    }

    public class SpanishSpellchecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check Done in Spanish");
        }
    }

    public class FrenchSpellchecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check Done in French");
        }
    }
    public class KlingonSpellchecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check Done in Klingon");
        }
    }
    public class HindiSpellchecker : ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check Done in Hindi");
        }
    }
}

