using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace Ean.Contracts.NovelWritingContract
{
    public class NovelWritingContractTestBase : DAppContractTestBase<NovelWritingContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal NovelWritingContractContainer.NovelWritingContractStub GetNovelWritingContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<NovelWritingContractContainer.NovelWritingContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}