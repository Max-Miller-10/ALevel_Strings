using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Systen.Text;



List<string> MexicanWave(string input)
{
	List<string> result = new List<string>();
	char[] chars = input.ToCharArray();

	for (int i = 0; i < input.Length; i++){
		if (chars[i] == ' '){continue;}
		chars[i] = char.ToUpper(chars[i]);
		result.Add(new string(chars));
		chars[i] = input[i];
	}
	return result;
}

Debug.Assert(MexicanWave("hello")[2] == "heLlo");


List<int> CharacterCodes(string input){
	List<int> result = new List<int>();

	foreach (char c in input){
		result.Add((int)c);
	}
	return result;
}


string StringFromCharCodes(List<int> input)
{
	StringBuilder sb = new StringBuilder();


	foreach (int code in input){
		sb.Append((char)code);
	}

	return sb.ToString();
}


