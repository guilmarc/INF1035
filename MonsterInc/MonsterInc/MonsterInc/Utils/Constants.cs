namespace Core
{
    public static class Constants
    {
        public const int ActiveInventoryCount = 5;
        public const int InitGoldCount = 1000;
        public const int MaxActiveMonstersCount = 5;
        public const float HumanizeFactor = 0.2f;
        public const string SavedGameFileExtension = ".game";
        private const string SavedGameFolderName = "Games/";
        private const string UniverseDataFolderName = "Universe/";
        public const string MonsterIncRootPath = "C:/MonsterInc/";
        public const string UniverseDataPath = MonsterIncRootPath + UniverseDataFolderName;
        public const string SavedGamePath = MonsterIncRootPath + SavedGameFolderName;
    }
}