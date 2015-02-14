using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Spatial;
using System.Linq.Expressions;
using System.Reflection;
using EntityFramework.Encapsulation.Conventions;

namespace EntityFramework.Encapsulation
{
    public static class PrivateMapperExtensions
    {
        #region String
        public static StringPropertyConfiguration PrivateProperty<T>(
            this EntityTypeConfiguration<T> mapper,
            Expression<Func<T, string>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression,convention, out defaultColumnName);
            StringPropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        } 
        #endregion

        #region DateTime
        public static DateTimePropertyConfiguration PrivateProperty<T>(
            this EntityTypeConfiguration<T> mapper,
            Expression<Func<T, DateTime>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DateTimePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }

        public static DateTimePropertyConfiguration PrivateProperty<T>(
            this EntityTypeConfiguration<T> mapper,
            Expression<Func<T, DateTime?>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DateTimePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        } 
        #endregion

        #region DateTimeOffset
        public static DateTimePropertyConfiguration PrivateProperty<T>(
            this EntityTypeConfiguration<T> mapper,
            Expression<Func<T, DateTimeOffset>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DateTimePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }

        public static DateTimePropertyConfiguration PrivateProperty<T>(
            this EntityTypeConfiguration<T> mapper,
            Expression<Func<T, DateTimeOffset?>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DateTimePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }  
        #endregion

        #region DbGeometry & DbGeography
        public static PrimitivePropertyConfiguration PrivateProperty<T>(
           this EntityTypeConfiguration<T> mapper,
           Expression<Func<T, DbGeometry>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            PrimitivePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }

        public static PrimitivePropertyConfiguration PrivateProperty<T>(
           this EntityTypeConfiguration<T> mapper,
           Expression<Func<T, DbGeography>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            PrimitivePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }
        #endregion

        #region T & Nullable-T
        public static PrimitivePropertyConfiguration PrivateProperty<T, U>(
          this EntityTypeConfiguration<T> mapper,
          Expression<Func<T, U>> exp,
            NamingConventions? convention = null)
            where T : class
            where U : struct
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            PrimitivePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }

        public static PrimitivePropertyConfiguration PrivateProperty<T, U>(
          this EntityTypeConfiguration<T> mapper,
          Expression<Func<T, U?>> exp,
            NamingConventions? convention = null)
            where T : class
            where U : struct
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            PrimitivePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        } 
        #endregion

        #region TimeSpan
        public static DateTimePropertyConfiguration PrivateProperty<T>(
          this EntityTypeConfiguration<T> mapper,
          Expression<Func<T, TimeSpan>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DateTimePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }

        public static DateTimePropertyConfiguration PrivateProperty<T>(
          this EntityTypeConfiguration<T> mapper,
          Expression<Func<T, TimeSpan?>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DateTimePropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }
        #endregion

        #region Byte-Array
        public static BinaryPropertyConfiguration PrivateProperty<T>(
          this EntityTypeConfiguration<T> mapper,
          Expression<Func<T, byte[]>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            BinaryPropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }
        #endregion

        #region Decimal
        public static DecimalPropertyConfiguration PrivateProperty<T>(
          this EntityTypeConfiguration<T> mapper,
          Expression<Func<T, decimal>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DecimalPropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        }

        public static DecimalPropertyConfiguration PrivateProperty<T>(
          this EntityTypeConfiguration<T> mapper,
          Expression<Func<T, decimal?>> exp,
            NamingConventions? convention = null) where T : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string defaultColumnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out defaultColumnName);
            DecimalPropertyConfiguration configuration = mapper.Property(expression);
            configuration.HasColumnName(defaultColumnName);
            return configuration;
        } 
        #endregion

        #region Collections
        public static ManyNavigationPropertyConfiguration<T, TTarget> HasManyPrivate<T, TTarget>(
           this EntityTypeConfiguration<T> mapper,
            Expression<Func<T, ICollection<TTarget>>> exp,
            NamingConventions? convention = null)
            where T : class
            where TTarget : class
        {
            mapper.Ignore(exp);
            dynamic expression = exp;
            string columnName;
            ExpressionModifier.ToPrivate(ref expression, convention, out columnName);
            return mapper.HasMany(expression);
        }

        #endregion

    }
}
