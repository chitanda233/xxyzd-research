package com.czhj.wire;

import com.czhj.wire.Message;
import com.czhj.wire.Message.Builder;
import java.io.IOException;
import java.io.ObjectStreamException;
import java.io.Serializable;
import java.io.StreamCorruptedException;

/* JADX INFO: loaded from: classes2.dex */
final class MessageSerializedForm<M extends Message<M, B>, B extends Message.Builder<M, B>> implements Serializable {
    private static final long serialVersionUID = 0;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final byte[] f2357a;
    private final Class<M> b;

    MessageSerializedForm(byte[] bArr, Class<M> cls) {
        this.f2357a = bArr;
        this.b = cls;
    }

    Object readResolve() throws ObjectStreamException {
        try {
            return ProtoAdapter.get(this.b).decode(this.f2357a);
        } catch (IOException e) {
            throw new StreamCorruptedException(e.getMessage());
        }
    }
}
