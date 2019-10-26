using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class GetMiddleCharacterTest
    {
        [Theory]
        [InlineData("w", "w")]
        [InlineData("wo", "wo")]
        [InlineData("wor", "o")]
        [InlineData("word", "or")]
        [InlineData("testing", "t")]
        [InlineData("middle", "dd")]
        [InlineData("A", "A")]
        [InlineData("1234567890", "56")]
        [InlineData("!@#$%^&*()", "%^")]
        [InlineData("123 678", " ")]
        [InlineData("aoierngai;erg;naeriognaeori;gnaer;oignaer;oignaeroi;gnaeroig;naegigaoergiaerngioaernggaoier[gmaioergmaieorgmapregmaoeprgopaermgopaermgoapergmoapergmaoeprgmaeoprgmaeorpgmaeorpgmaeoprbaop'erbmerbmfld'bmfdlbml;'bmal';rmal'ermblaerbm;learbmla';bmear'bmearl;bmaerl;bmafdl;bmaldmasasaoierngai;erg;naeriognaeori;gnaer;oignaer;oignaeroi;gnaeroig;naegigaoergiaerngioaernggaoier[gmaioergmaieorgmapregmaoeprgopaermgopaermgoapergmoapergmaoeprgmaeoprgmaeorpgmaeorpgmaeoprbaop'erbmerbmfld'bmfdlbml;'bmal';rmal'ermblaerbm;learbmla';bmear'bmearl;bmaerl;bmafdl;bmaldmaaoierngai;erg;naeriognaeori;gnaer;oignaer;oignaeroi;gnaeroig;naegigaoergiaerngioaernggaoier[gmaioergmaieorgmapregmaoeprgopaermgopaermgoapergmoapergmaoeprgmaeoprgmaeorpgmaeorpgmaeoprbaop'erbmerbmfld'bmfdlbml;'bmal';rmal'ermblaerbm;learbmla';bmear'bmearl;bmaerl;bmafdl;bmaldmaaoierngai;erg;naeriognaeori;gnaer;oignaer;oignaeroi;gnaeroig;naegigaoergiaerngioaernggaoier[gmaioergmaieorgmapregmaoeprgopaermgopaermgoapergmoapergmaoeprgmaeoprsavasvasvasvvq", "b")]
        public void Test(string word, string expected)
        {
            // act
            string actual = GetMiddleCharacterKata.GetMiddle(word);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}