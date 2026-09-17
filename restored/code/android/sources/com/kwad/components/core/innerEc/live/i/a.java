package com.kwad.components.core.innerEc.live.i;

import com.kwad.components.offline.api.core.adInnerEc.longconnection.ServerException;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static ServerException l(Throwable th) {
        ServerException serverException = (ServerException) th;
        return new ServerException(serverException.errorCode, serverException.subCode, serverException.errorMessage);
    }
}
