package cn.thinkingdata.analytics.h;

/* JADX INFO: loaded from: classes.dex */
public class f {
    public static boolean a(Object obj, String str) {
        for (Class<?> superclass = obj.getClass(); superclass.getCanonicalName() != null; superclass = superclass.getSuperclass()) {
            if (superclass.getCanonicalName().equals(str)) {
                return true;
            }
            if (superclass == Object.class) {
                return false;
            }
        }
        return false;
    }
}
