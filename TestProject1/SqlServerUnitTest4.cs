﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass()]
    public class SqlServerUnitTest4 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest4()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction HumanResources_uspUpdateEmployeePersonalInfoTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest4));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            this.HumanResources_uspUpdateEmployeePersonalInfoTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            HumanResources_uspUpdateEmployeePersonalInfoTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            // 
            // HumanResources_uspUpdateEmployeePersonalInfoTestData
            // 
            this.HumanResources_uspUpdateEmployeePersonalInfoTestData.PosttestAction = null;
            this.HumanResources_uspUpdateEmployeePersonalInfoTestData.PretestAction = null;
            this.HumanResources_uspUpdateEmployeePersonalInfoTestData.TestAction = HumanResources_uspUpdateEmployeePersonalInfoTest_TestAction;
            // 
            // HumanResources_uspUpdateEmployeePersonalInfoTest_TestAction
            // 
            HumanResources_uspUpdateEmployeePersonalInfoTest_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            resources.ApplyResources(HumanResources_uspUpdateEmployeePersonalInfoTest_TestAction, "HumanResources_uspUpdateEmployeePersonalInfoTest_TestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void HumanResources_uspUpdateEmployeePersonalInfoTest()
        {
            SqlDatabaseTestActions testActions = this.HumanResources_uspUpdateEmployeePersonalInfoTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions HumanResources_uspUpdateEmployeePersonalInfoTestData;
    }
}
