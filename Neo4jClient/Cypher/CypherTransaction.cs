﻿using System;
using System.Transactions;

namespace Neo4jClient.Cypher
{
    class CypherTransaction : IEnlistmentNotification
    {
        readonly ITransactionCoordinator transactionCoordinator;
        readonly string localIdentifier;

        public CypherTransaction(
            ITransactionCoordinator transactionCoordinator,
            string localIdentifier)
        {
            this.transactionCoordinator = transactionCoordinator;
            this.localIdentifier = localIdentifier;
        }

        public Uri Endpoint { get; set; }

        public string LocalIdentifier
        {
            get { return localIdentifier; }
        }

        public void Prepare(PreparingEnlistment preparingEnlistment)
        {
        }

        public void Commit(Enlistment enlistment)
        {
        }

        public void Rollback(Enlistment enlistment)
        {
            transactionCoordinator.RollbackTransaction(this);
            enlistment.Done();
        }

        public void InDoubt(Enlistment enlistment)
        {
        }
    }
}
