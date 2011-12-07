#include "gpu_vcd_sf_mp_test.h"
#include "gpu_vcd_sf_mp.h"
#include "vcd_common.h"

GpuVcdSfMpTest::GpuVcdSfMpTest(void)
{

}

GpuVcdSfMpTest::~GpuVcdSfMpTest(void)
{

}

void GpuVcdSfMpTest::setInputPath(string path)
{
	m_path = path;
}

void GpuVcdSfMpTest::run(void)
{
	m_libraw.recycle();
	m_libraw.imgdata.params.document_mode = 2;
	m_libraw.imgdata.params.output_bps = 16;
	m_libraw.imgdata.params.user_flip = 0;
	m_libraw.imgdata.params.no_auto_bright = 0;
	m_libraw.open_file(m_path.c_str());
	m_libraw.unpack();
	unsigned short* output = new unsigned short[m_libraw.imgdata.sizes.raw_width * m_libraw.imgdata.sizes.raw_height];
	int output_stride = m_libraw.imgdata.sizes.raw_width;
	vcd_params params;
	vcd_params_init(&params, 2.0f, 2, 2, 4, 0, 0, m_libraw.imgdata.sizes.raw_width, m_libraw.imgdata.sizes.raw_height, m_libraw.imgdata.sizes.raw_width, m_libraw.imgdata.sizes.raw_height, m_libraw.fc(0, 0));
	vcd_sf_mp_kernel_times times;
	gpu_vcd_sf_singlegpu_multipass<float>(0, output, output_stride, m_libraw.imgdata.sizes.raw_width, m_libraw.imgdata.sizes.raw_height, 
		m_libraw.imgdata.rawdata.raw_image, m_libraw.imgdata.sizes.raw_width, m_libraw.imgdata.sizes.raw_height, m_libraw.imgdata.idata.filters, params, &times, NULL);
}