package com.kuaishou.weapon.p0;

/* JADX INFO: loaded from: classes3.dex */
public class cp {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile boolean f2684a = false;
    private static volatile boolean b = true;

    static {
        try {
            f2684a = ((Boolean) Class.forName("dalvik.system.VMRuntime").getDeclaredMethod("is64Bit", new Class[0]).invoke(Class.forName("dalvik.system.VMRuntime").getDeclaredMethod("getRuntime", new Class[0]).invoke(null, new Object[0]), new Object[0])).booleanValue();
        } catch (Exception unused) {
            f2684a = false;
        }
        b = System.getProperty("java.vm.version").startsWith("2");
    }

    public static boolean a() {
        return f2684a;
    }

    public static boolean b() {
        return b;
    }
}
