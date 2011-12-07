#include "gpu_vcd_sf_mp_test.h"

int main(int argc, char* argv[])
{
	GpuVcdSfMpTest test;
	test.setInputPath(argv[1]);
	test.run();
}