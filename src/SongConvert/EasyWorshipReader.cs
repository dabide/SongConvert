using System.Collections.Generic;
using System.Linq;
using WindowsApplication1.Entities;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.JetDriver;

namespace WindowsApplication1
{
    internal class EasyWorshipReader
    {
        private readonly SessionSource _sessionSource;

        public EasyWorshipReader(string easyWorshipSongPath)
        {
            var initialConfiguration = new Configuration();
            initialConfiguration.SetNamingStrategy(new ParadoxNamingStrategy());

            var fluentConfiguration =
                Fluently.Configure(initialConfiguration)
                    .Database(JetDriverConfiguration.Standard.ConnectionString(
                        $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={easyWorshipSongPath};Extended Properties=\"Paradox 5.x;CharacterSet=65001;\"")
                        .Dialect<JetDialect>()
                        .Driver<OleDbDriver>())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MainForm>());

            _sessionSource = new SessionSource(fluentConfiguration);
        }

        public List<Song> GetSongs()
        {
            using (var session = _sessionSource.CreateSession())
            {
                return session.QueryOver<Song>().List().ToList();
            }
        }
    }
}