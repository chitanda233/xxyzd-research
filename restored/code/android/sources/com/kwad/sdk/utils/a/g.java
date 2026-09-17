package com.kwad.sdk.utils.a;

import java.util.LinkedHashSet;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
final class g implements c.b<Set<String>> {
    static final g bsD = new g();

    @Override // com.kwad.sdk.utils.a.c.b
    public final String XM() {
        return "StringSet";
    }

    @Override // com.kwad.sdk.utils.a.c.b
    public final /* synthetic */ Set<String> f(byte[] bArr, int i, int i2) {
        return g(bArr, i, i2);
    }

    @Override // com.kwad.sdk.utils.a.c.b
    public final /* synthetic */ byte[] u(Set<String> set) {
        return e(set);
    }

    private g() {
    }

    private static byte[] e(Set<String> set) {
        if (set.isEmpty()) {
            return new byte[0];
        }
        int size = set.size();
        int[] iArr = new int[size];
        String[] strArr = new String[size];
        int iFX = 0;
        int i = 0;
        for (String str : set) {
            if (str == null) {
                iFX += 5;
                iArr[i] = -1;
            } else {
                int iIt = b.it(str);
                strArr[i] = str;
                iArr[i] = iIt;
                iFX += b.fX(iIt) + iIt;
            }
            i++;
        }
        b bVar = new b(iFX);
        for (int i2 = 0; i2 < size; i2++) {
            int i3 = iArr[i2];
            bVar.fW(i3);
            if (i3 >= 0) {
                bVar.is(strArr[i2]);
            }
        }
        return bVar.brL;
    }

    private static Set<String> g(byte[] bArr, int i, int i2) {
        LinkedHashSet linkedHashSet = new LinkedHashSet();
        if (i2 > 0) {
            b bVar = new b(bArr, i);
            int i3 = i + i2;
            while (bVar.position < i3) {
                linkedHashSet.add(bVar.getString(bVar.Xs()));
            }
            if (bVar.position != i3) {
                throw new IllegalArgumentException("Invalid String set");
            }
        }
        return linkedHashSet;
    }
}
