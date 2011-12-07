#ifndef GPU_VCD_SF_MP_TEST_H
#define GPU_VCD_SF_MP_TEST_H

#include <iostream>
#include <libraw.h>

using namespace std;

class GpuVcdSfMpTest
{
public:
	GpuVcdSfMpTest(void);

	~GpuVcdSfMpTest(void);

	void run(void);
	
	void setInputPath(string path);

private:
	string m_path;
	LibRaw m_libraw;
};

#endif