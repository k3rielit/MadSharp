namespace GameLogic {
    internal class TrackZipLoader {
        public static RadicalMusic LoadLegacy(int i, string astring, int i52) {
            //            throw new NotImplementedException();
            return new RadicalMusic(new File("music/stage" + i + ".zip"));
        }
    }
}