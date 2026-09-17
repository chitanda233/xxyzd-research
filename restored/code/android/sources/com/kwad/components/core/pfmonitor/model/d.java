package com.kwad.components.core.pfmonitor.model;

import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private final boolean aiz;
    private final File file;
    private final String fileName;
    private final String filePath;
    private final long size;

    public d(File file, long j, boolean z) {
        this.file = file;
        this.size = j;
        this.aiz = z;
        this.fileName = file.getName();
        this.filePath = file.getAbsolutePath();
    }

    public final File getFile() {
        return this.file;
    }

    public final boolean isDirectory() {
        return this.aiz;
    }

    public final String getFileName() {
        return this.fileName;
    }

    public final String toString() {
        Object[] objArr = new Object[3];
        objArr[0] = this.aiz ? "[DIR] " : "[FILE] ";
        objArr[1] = this.filePath;
        objArr[2] = com.kwad.components.core.pfmonitor.d.M(this.size);
        return String.format("%s%s - %s", objArr);
    }
}
