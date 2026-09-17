package ms.bz.bd.c.Pgl;

import android.content.Context;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes4.dex */
public final class a2 {
    private final Context c;
    private Class tt;
    private Method uj;
    private Object ve;

    public a2(Context context) {
        int i;
        int i2;
        this.c = context;
        try {
            i = 1;
            i2 = 7;
            try {
                Class<?> cls = Class.forName((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "6fd825", new byte[]{36, 107, 26, 2, 12, 44, com.sigmob.sdk.archives.tar.e.I, 85, 58, 97, 35, 42, 30, 72, 67, 43, 56, 87, 57, 38, 14, 96, 39, 94, 2, com.sigmob.sdk.archives.tar.e.L, 60, 67, com.sigmob.sdk.archives.tar.e.H, 122, 14, 105, 7, 64}));
                this.tt = cls;
                this.ve = cls.newInstance();
            } catch (Exception unused) {
            }
        } catch (Exception unused2) {
            i = 1;
            i2 = 7;
        }
        try {
            Class cls2 = this.tt;
            byte[] bArr = new byte[i2];
            bArr[0] = 35;
            bArr[i] = 63;
            bArr[2] = 94;
            bArr[3] = 57;
            bArr[4] = 42;
            bArr[5] = 13;
            bArr[6] = 18;
            String str = (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "589b43", bArr);
            Class<?>[] clsArr = new Class[i];
            clsArr[0] = Context.class;
            this.uj = cls2.getMethod(str, clsArr);
        } catch (Exception unused3) {
        }
    }

    public final String c() {
        Context context = this.c;
        Method method = this.uj;
        Object obj = this.ve;
        if (obj != null && method != null) {
            try {
                return (String) method.invoke(obj, context);
            } catch (Exception unused) {
            }
        }
        return null;
    }
}
