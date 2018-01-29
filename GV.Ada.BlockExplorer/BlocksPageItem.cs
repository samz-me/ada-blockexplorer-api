﻿using Newtonsoft.Json;

namespace GV.Ada.BlockExplorer
{
	public class BlocksPageItem
	{

		[JsonProperty("cbeEpoch")]
		public int Epoch { get; set; }

		[JsonProperty("cbeSlot")]
		public int Slot { get; set; }

		[JsonProperty("cbeBlkHash")]
		public string BlkHash { get; set; }

		[JsonProperty("cbeTimeIssued")]
		public long TimeIssued { get; set; }

		[JsonProperty("cbeTxNum")]
		public int TxNum { get; set; }

		[JsonProperty("cbeTotalSent")]
		public CoinInfo TotalSent { get; set; }

		[JsonProperty("cbeSize")]
		public int Size { get; set; }

		[JsonProperty("cbeBlockLead")]
		public string BlockLead { get; set; }

		[JsonProperty("cbeFees")]
		public Fees Fees { get; set; }
	}
}
