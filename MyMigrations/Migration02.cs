using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MyMigrations
{

    [Migration(2)]
    public class Migration02 : Migration
    {
        public override void Up()
        {
            Execute.Script(@"DBScripts\02_initial_schema.sql");
        }

        public override void Down()
        {
            // This migration has not down
        }
    }
}
