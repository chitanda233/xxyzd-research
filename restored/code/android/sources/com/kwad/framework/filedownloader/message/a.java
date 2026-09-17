package com.kwad.framework.filedownloader.message;

/* JADX INFO: loaded from: classes3.dex */
public interface a {
    MessageSnapshot CV();

    /* JADX INFO: renamed from: com.kwad.framework.filedownloader.message.a$a, reason: collision with other inner class name */
    public static class C0488a extends MessageSnapshot implements a {
        private final MessageSnapshot aCu;

        @Override // com.kwad.framework.filedownloader.message.c
        public final byte AT() {
            return (byte) 4;
        }

        public C0488a(MessageSnapshot messageSnapshot) {
            super(messageSnapshot.getId());
            if (messageSnapshot.AT() != -3) {
                throw new IllegalArgumentException(com.kwad.framework.filedownloader.f.f.c("can't create the block complete message for id[%d], status[%d]", Integer.valueOf(messageSnapshot.getId()), Byte.valueOf(messageSnapshot.AT())));
            }
            this.aCu = messageSnapshot;
        }

        @Override // com.kwad.framework.filedownloader.message.a
        public final MessageSnapshot CV() {
            return this.aCu;
        }
    }
}
