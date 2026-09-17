package com.kwad.framework.filedownloader.message;

import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public class f {
    public static MessageSnapshot a(int i, File file, boolean z) {
        long length = file.length();
        if (length > 2147483647L) {
            if (z) {
                return new d.a(i, true, length);
            }
            return new d.b(i, true, length);
        }
        if (z) {
            return new h.a(i, true, (int) length);
        }
        return new h.b(i, true, (int) length);
    }

    public static MessageSnapshot a(int i, long j, long j2, boolean z) {
        if (j2 > 2147483647L) {
            if (z) {
                return new d.i(i, j, j2);
            }
            return new d.j(i, j, j2);
        }
        if (z) {
            return new h.i(i, (int) j, (int) j2);
        }
        return new h.j(i, (int) j, (int) j2);
    }

    public static MessageSnapshot a(int i, long j, Throwable th) {
        if (j > 2147483647L) {
            return new d.C0489d(i, j, th);
        }
        return new h.d(i, (int) j, th);
    }

    public static MessageSnapshot e(com.kwad.framework.filedownloader.a aVar) {
        if (aVar.AZ()) {
            return new d.e(aVar.getId(), aVar.AQ(), aVar.AS());
        }
        return new h.e(aVar.getId(), aVar.getSmallFileSoFarBytes(), aVar.getSmallFileTotalBytes());
    }

    public static MessageSnapshot t(MessageSnapshot messageSnapshot) {
        if (messageSnapshot.AT() != -3) {
            throw new IllegalStateException(com.kwad.framework.filedownloader.f.f.c("take block completed snapshot, must has already be completed. %d %d", Integer.valueOf(messageSnapshot.getId()), Byte.valueOf(messageSnapshot.AT())));
        }
        return new a.C0488a(messageSnapshot);
    }

    public static MessageSnapshot a(byte b, com.kwad.framework.filedownloader.d.c cVar, com.kwad.framework.filedownloader.download.d.a aVar) {
        MessageSnapshot dVar;
        IllegalStateException illegalStateException;
        int id = cVar.getId();
        if (b == -4) {
            throw new IllegalStateException(com.kwad.framework.filedownloader.f.f.c("please use #catchWarn instead %d", Integer.valueOf(id)));
        }
        if (b == -3) {
            if (cVar.AZ()) {
                return new d.b(id, false, cVar.getTotal());
            }
            return new h.b(id, false, (int) cVar.getTotal());
        }
        if (b != -1) {
            if (b == 1) {
                if (cVar.AZ()) {
                    return new d.f(id, cVar.Dj(), cVar.getTotal());
                }
                return new h.f(id, (int) cVar.Dj(), (int) cVar.getTotal());
            }
            if (b == 2) {
                String filename = cVar.AN() ? cVar.getFilename() : null;
                if (cVar.AZ()) {
                    return new d.c(id, aVar.CO(), cVar.getTotal(), cVar.Dk(), filename);
                }
                return new h.c(id, aVar.CO(), (int) cVar.getTotal(), cVar.Dk(), filename);
            }
            if (b == 3) {
                if (cVar.AZ()) {
                    return new d.g(id, cVar.Dj());
                }
                return new h.g(id, (int) cVar.Dj());
            }
            if (b != 5) {
                if (b == 6) {
                    return new MessageSnapshot.b(id);
                }
                String strC = com.kwad.framework.filedownloader.f.f.c("it can't takes a snapshot for the task(%s) when its status is %d,", cVar, Byte.valueOf(b));
                com.kwad.framework.filedownloader.f.d.d(f.class, "it can't takes a snapshot for the task(%s) when its status is %d,", cVar, Byte.valueOf(b));
                if (aVar.getException() != null) {
                    illegalStateException = new IllegalStateException(strC, aVar.getException());
                } else {
                    illegalStateException = new IllegalStateException(strC);
                }
                if (cVar.AZ()) {
                    return new d.C0489d(id, cVar.Dj(), illegalStateException);
                }
                return new h.d(id, (int) cVar.Dj(), illegalStateException);
            }
            if (cVar.AZ()) {
                dVar = new d.h(id, cVar.Dj(), aVar.getException(), aVar.AX());
            } else {
                dVar = new h.C0490h(id, (int) cVar.Dj(), aVar.getException(), aVar.AX());
            }
        } else if (cVar.AZ()) {
            dVar = new d.C0489d(id, cVar.Dj(), aVar.getException());
        } else {
            dVar = new h.d(id, (int) cVar.Dj(), aVar.getException());
        }
        return dVar;
    }
}
