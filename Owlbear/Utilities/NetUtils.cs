#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Owlbear.Utilities
{
    public class NetUtils
    {
        public static readonly string TwitchBearerToken = Environment.GetEnvironmentVariable("TWITCH_BEARER") ?? throw new InvalidOperationException();
        public static readonly string TwitchClientId = Environment.GetEnvironmentVariable("TWITCH_CLIENT_ID") ?? throw new InvalidOperationException();
        public static readonly string TwitterBearerToken = Environment.GetEnvironmentVariable("TWITTER_BEARER") ?? throw new InvalidOperationException();
        public static readonly string YoutubeApiKey = Environment.GetEnvironmentVariable("YOUTUBE_API_KEY") ?? throw new InvalidOperationException();
        public static readonly string TwitterApiKey = Environment.GetEnvironmentVariable("TWITTER_API_KEY") ?? throw new InvalidOperationException();
        public static readonly string TwitterApiSecret = Environment.GetEnvironmentVariable("TWITTER_API_SECRET") ?? throw new InvalidOperationException();
        public static readonly string TwitterAccessToken = Environment.GetEnvironmentVariable("TWITTER_ACCESS_TOKEN") ?? throw new InvalidOperationException();
        public static readonly string TwitterAccessSecret = Environment.GetEnvironmentVariable("TWITTER_ACCESS_SECRET") ?? throw new InvalidOperationException();

        public static readonly HttpClient Client = new();

        public class QueryBuilder : SortedDictionary<string, ParameterList>
        {
            
            private readonly string _address;
            
            public QueryBuilder(string address)
            {
                _address = address;
            }

            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.Append(_address);

                string? prev = null;
                foreach (var (key, value) in this)
                {
                    if(value == null || value.Count == 0) continue;
                    builder.Append(prev == null ? '?' : '&');
                    builder.Append(key).Append('=');
                    builder.AppendJoin(',', value);
                    prev = key;
                }
                
                return builder.ToString();
            }
            
            public new ParameterList this[string key]
            {
                get
                {
                    try
                    {
                        return base[key];
                    }
                    catch (KeyNotFoundException)
                    {
                        this[key] = new ParameterList();
                        return base[key];
                    }
                }
                set => base[key] = value;
            }
        }
        
        
        public class ParameterList : List<string>
        {
            public static ParameterList operator +(ParameterList list, string? value)
            {
                if (value == null) return list;
                list.Add(value);
                return list;
            }
            
            public static ParameterList operator -(ParameterList list, string? value)
            {
                if (value == null) return list;
                list.Remove(value);
                return list;
            }
            
            public static ParameterList operator +(ParameterList list, ParameterList? other)
            {
                if (other == null) return list;
                list.AddRange(other);
                return list;
            }
            
            public static ParameterList operator -(ParameterList list, ParameterList? other)
            {
                if (other == null) return list;
                list.RemoveAll(other.Contains);
                return list;
            }
            
            public static ParameterList operator +(ParameterList list, string[]? other)
            {
                if (other == null) return list;
                list.AddRange(other);
                return list;
            }
            
            public static ParameterList operator -(ParameterList list, string[]? other)
            {
                if (other == null) return list;
                list.RemoveAll(other.Contains);
                return list;
            }
        }
    }
}