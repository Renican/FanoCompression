﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FanoCompression.FanoTree
{
    class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public long? leaf;

        public Word? value;

        public TreeNode(){}
        public TreeNode(Word? value)
        {
            this.value = value;
        }
        public TreeNode(long? leaf)
        {
            this.leaf = leaf;
        }
    }
}
