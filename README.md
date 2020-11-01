# Cloth-and-Fracturing
在布料仿真上，主要修改的是IMDT\Assets\IMDT\COURSE\Cloth\Characters\Scenes\homework-scene，参考demo-scene使用了Spring Bone和Cloth组件实现了布料模拟效果，并修改了一些参数以改善穿模现象。生成的可执行文件位于 /IMDT/Cloth/ 目录下。
在物理破坏上，主要修改的是IMDT\Assets\IMDT\COURSE\BreakableObjects\Fractured&Destruction Plugin\fracturing\Assets\Ultimate Game Tools\Fracturing\01 Sample Scene。使用了Fracturing & Destruction插件将demo中的箱子和小球用BSP和Voronri两种方式进行分割，并实现了破坏效果及与场景的交互。生成的可执行文件位于/IMDT/Fracturing/目录下，用鼠标左键控制枪口移动，空格键射击。
