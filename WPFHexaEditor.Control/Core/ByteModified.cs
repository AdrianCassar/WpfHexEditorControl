﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHexaEditor.Control.Core
{
    public class ByteModified
    {
        private byte? _byte = null;
        private ByteAction _action = ByteAction.Nothing;
        private long _position = -1;
        
        /// <summary>
        /// Byte mofidied
        /// </summary>
        public byte? Byte
        {
            get
            {
                return _byte;
            }

            set
            {
                _byte = value;
            }
        }

        /// <summary>
        /// Action have made in this byte
        /// </summary>
        public ByteAction Action
        {
            get
            {
                return _action;
            }

            set
            {
                _action = value;
            }
        }

        /// <summary>
        /// Get of Set te position in file
        /// </summary>
        public long BytePositionInFile
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }
        
        /// <summary>
        /// Check if the object is valid and data can be used for action
        /// </summary>
        public bool IsValid
        {
            get
            {
                if (BytePositionInFile > -1 && Action != ByteAction.Nothing && Byte != null)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Clear object
        /// </summary>
        public void Clear()
        {
            _byte = null;
            _action = ByteAction.Nothing;
            _position = -1;
        }

        /// <summary>
        /// Copy Current instance to another
        /// </summary>
        /// <returns></returns>
        public ByteModified GetCopy()
        {
            ByteModified newByteModified = new ByteModified();
            object copied = null;

            newByteModified.Action = this.Action;
            newByteModified.Byte = this.Byte.Value;
            newByteModified.BytePositionInFile = this.BytePositionInFile;

            copied = newByteModified;
            
            return (ByteModified)copied;
        }

        public override string ToString()
        {
            return $"ByteModified - Action:{Action} Position:{BytePositionInFile} Byte:{Byte}";
        }
    }
}
