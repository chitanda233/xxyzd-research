package ms.bz.bd.c.Pgl;

import cn.thinkingdata.core.router.TRouterMap;
import java.util.Arrays;

/* JADX INFO: loaded from: classes4.dex */
public final class b1 extends RuntimeException {
    public b1(String str, String[] strArr, String[] strArr2) {
        super("Could not find '" + str + "'. Looked for: " + Arrays.toString(strArr) + ", but only found: " + Arrays.toString(strArr2) + TRouterMap.DOT);
    }
}
