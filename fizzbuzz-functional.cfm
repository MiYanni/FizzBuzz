<!--- 565-580 ms --->
<cfscript>
	private boolean function mod3(numeric idx)
	{
		return (idx mod 3 == 0);
	}

	private boolean function mod5(numeric idx)
	{
		return (idx mod 5 == 0);
	}

	private boolean function mod3Or5(numeric idx)
	{
		return (mod3(idx) || mod5(idx));
	}

	private void function renderFizzOrBuzz(numeric idx)
	{
		if(mod3(idx)) { writeOutput('Fizz'); };
		if(mod5(idx)) { writeOutput('Buzz'); };
	}

	private void function renderNumber(numeric idx)
	{
		writeOutput(idx);
	}

	private void function render(numeric idx)
	{
		if(mod3Or5(idx))
		{
			renderFizzOrBuzz(idx);
		}
		else
		{
			renderNumber(idx);
		}
		writeOutput('<br>');
	}

	private void function startLoop2()
	{
		for(var idx = 1; idx <= 100; ++idx)
		{
			render(idx);
		}
	}

	private void function startLoop()
	{
		for(var t = 1; t <= 1000; ++t)
		{
			startLoop2();
		}
	}

	startTime = getTickCount();
	startLoop();
	writeOutput('FunctionCfscriptTime: ' & (getTickCount() - startTime));
</cfscript>