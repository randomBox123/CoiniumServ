﻿namespace Coinium.Persistance.Blocks
{
    public class KickedBlock:IKickedBlock
    {
        public uint Height { get; private set; }
        public BlockStatus Status { get; private set; }
        public string BlockHash { get; private set; }
        public string TransactionHash { get; private set; }
        public decimal Reward { get; set; }
        public decimal Amount { get; set; }

        public KickedBlock(uint height, string blockHash, string transactionHash, decimal amount, decimal reward)
        {
            Height = height;
            BlockHash = blockHash;
            TransactionHash = transactionHash;
            Amount = amount;
            Reward = reward;
            Status = BlockStatus.Kicked;
        }

        public KickedBlock(uint height, IHashCandidate candidate)
            : this(height, candidate.BlockHash, candidate.TransactionHash, candidate.Amount, candidate.Reward)
        { }

        public override string ToString()
        {
            return string.Format("Height: {0}, Status: Kicked.", Height);
        }
    }
}
