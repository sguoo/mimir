using Lib9c;
using Mimir.Worker.Client;
using Mimir.Worker.Initializer.Manager;
using Mimir.Worker.Services;
using Serilog;

namespace Mimir.Worker.Handler.Balance;

public sealed class FreyaBlessingRuneBalanceHandler(
    MongoDbService dbService,
    IStateService stateService,
    IHeadlessGQLClient headlessGqlClient,
    IInitializerManager initializerManager)
    : BaseBalanceHandler("balance_freya_blessing_rune", dbService, stateService, headlessGqlClient, initializerManager,
        Log.ForContext<FreyaBlessingRuneBalanceHandler>(), Currencies.FreyaBlessingRune);
