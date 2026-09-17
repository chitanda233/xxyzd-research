package com.sigmob.sdk.downloader;

import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public interface c {
    void a(f task, int blockIndex, int responseCode, Map<String, List<String>> responseHeaderFields);

    void a(f task, int blockIndex, long contentLength);

    void a(f task, int responseCode, Map<String, List<String>> responseHeaderFields);

    void a(f task, com.sigmob.sdk.downloader.core.breakpoint.c info);

    void a(f task, com.sigmob.sdk.downloader.core.breakpoint.c info, com.sigmob.sdk.downloader.core.cause.b cause);

    void a(f task, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause);

    void a(f task, Map<String, List<String>> requestHeaderFields);

    void a_(f task);

    void b(f task, int blockIndex, long increaseBytes);

    void b(f task, int blockIndex, Map<String, List<String>> requestHeaderFields);

    void c(f task, int blockIndex, long contentLength);
}
