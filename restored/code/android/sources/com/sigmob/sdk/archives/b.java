package com.sigmob.sdk.archives;

/* JADX INFO: loaded from: classes2.dex */
public class b extends Exception {
    private static final long serialVersionUID = 2772690708123267100L;

    public b(String message) {
        super(message);
    }

    public b(String message, Exception cause) {
        super(message);
        initCause(cause);
    }
}
