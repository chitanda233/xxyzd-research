package com.czhj.wire;

/* JADX INFO: loaded from: classes2.dex */
final class Preconditions {
    private Preconditions() {
    }

    static void a(Object obj, String str) {
        if (obj == null) {
            throw new NullPointerException(str);
        }
    }
}
