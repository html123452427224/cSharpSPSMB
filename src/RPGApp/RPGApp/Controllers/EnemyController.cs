using Microsoft.AspNetCore.Mvc;

namespace RPGApp.Controllers;
using Enemy;

[Route("api/[controller]")]
public class EnemyController : Controller
{
    private readonly ILogger<EnemyController>  _logger;
    private readonly DBDriver _dbDriver;

    public EnemyController(ILogger<EnemyController> logger, DBDriver dbDriver)
    {
        _logger = logger;
        _dbDriver = dbDriver;
    }
    
    [HttpGet]

    public List<Enemy> GetAllENemies()
    {
        return _dbDriver.GetEnemies();
    }

    [HttpPost]

    public Enemy InsertEnemy([FromBody] Enemy enemy)
    {
        _dbDriver.InsertEnemy(enemy);
        return enemy;
    }
    
    
}