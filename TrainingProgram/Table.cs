namespace TrainingProgram
{
    class Table
    {
        private string[,] _table;
        private char _separator;
        private string[] _header;
        private int _row;
        private int _column;

        public Table(string source) //Row, column = i, j
        {
            _separator = ';';
            string[] table = File.ReadAllLines(source);
            _header = table[0].Split(_separator);

            _row = table.Length - 1;

            _column = _header.Length;

            _table = new string[_row, _column];

            for(int i = 0; i < _row; i++)
            {
                string[] line = table[i + 1].Split(_separator);

                for (int j = 0; j < _column; j++)
                {
                    _table[i, j] = line[j];
                }
            }
        }

        public Table(int row, int column)
        {
            _row = row;
            _column = column;

            _table = new string[_row, _column];

            _header = new string[_column];

            for(int i = 0; i < _header.Length; i++)
            {
                _header[i] = "col" + i;
            }
        }

        public string this[string column, int row]
        {
            get => _table[row, Array.IndexOf(_header, column)];

            set => _table[row, Array.IndexOf(_header, column)] = value;
        }

        public string this[int row, int column]
        {
            get => _table[row, column];

            set => _table[row, column] = value;
        }

        public void Print()
        {
            for(int i = 0; i < _header.Length; i++)
            {
                Console.Write(_header[i] + "\t");
            }

            Console.WriteLine();

            for(int i = 0; i < _row; i++)
            {
                for(int j = 0; j < _column; j++)
                {
                    Console.Write(_table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void InitRandom(int min, int max)
        {
            Random random = new Random();

            for(int i = 0; i < _row; i++)
            {
                for(int j = 0; j < _column; j++)
                {
                    _table[i, j] = random.Next(min, max).ToString();
                }
            }
        }
    }
}
