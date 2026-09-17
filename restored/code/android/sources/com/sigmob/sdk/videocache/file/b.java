package com.sigmob.sdk.videocache.file;

import com.kuaishou.weapon.p0.t;
import com.sigmob.sdk.videocache.p;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;

/* JADX INFO: loaded from: classes4.dex */
public class b implements com.sigmob.sdk.videocache.c {
    private static final String b = ".download";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public File f3661a;
    private final a c;
    private RandomAccessFile d;

    public b(File file) throws p {
        this(file, new i());
    }

    public b(File file, a diskUsage) throws p {
        try {
            if (diskUsage == null) {
                throw new NullPointerException();
            }
            this.c = diskUsage;
            d.a(file.getParentFile());
            boolean zExists = file.exists();
            this.f3661a = zExists ? file : new File(file.getParentFile(), file.getName() + b);
            this.d = new RandomAccessFile(this.f3661a, zExists ? t.k : "rw");
        } catch (IOException e) {
            throw new p("Error using file " + file + " as disc cache", e);
        }
    }

    private boolean a(File file) {
        return file.getName().endsWith(b);
    }

    @Override // com.sigmob.sdk.videocache.c
    public synchronized int a(byte[] buffer, long offset, int length) throws p {
        try {
            this.d.seek(offset);
        } catch (IOException e) {
            throw new p(String.format("Error reading %d bytes with offset %d from file[%d bytes] to buffer[%d bytes]", Integer.valueOf(length), Long.valueOf(offset), Long.valueOf(a()), Integer.valueOf(buffer.length)), e);
        }
        return this.d.read(buffer, 0, length);
    }

    @Override // com.sigmob.sdk.videocache.c
    public synchronized long a() throws p {
        try {
        } catch (IOException e) {
            throw new p("Error reading length of file " + this.f3661a, e);
        }
        return (int) this.d.length();
    }

    @Override // com.sigmob.sdk.videocache.c
    public synchronized void a(byte[] data, int length) throws p {
        try {
            if (d()) {
                throw new p("Error append cache: cache file " + this.f3661a + " is completed!");
            }
            this.d.seek(a());
            this.d.write(data, 0, length);
        } catch (IOException e) {
            throw new p(String.format("Error writing %d bytes to %s from buffer with size %d", Integer.valueOf(length), this.d, Integer.valueOf(data.length)), e);
        }
    }

    @Override // com.sigmob.sdk.videocache.c
    public synchronized void b() throws p {
        try {
            this.d.close();
            this.c.a(this.f3661a);
        } catch (IOException e) {
            throw new p("Error closing file " + this.f3661a, e);
        }
    }

    @Override // com.sigmob.sdk.videocache.c
    public synchronized void c() throws p {
        if (d()) {
            return;
        }
        b();
        File file = new File(this.f3661a.getParentFile(), this.f3661a.getName().substring(0, this.f3661a.getName().length() - 9));
        if (!this.f3661a.renameTo(file)) {
            throw new p("Error renaming file " + this.f3661a + " to " + file + " for completion!");
        }
        this.f3661a = file;
        try {
            this.d = new RandomAccessFile(this.f3661a, t.k);
            this.c.a(this.f3661a);
        } catch (IOException e) {
            throw new p("Error opening " + this.f3661a + " as disc cache", e);
        }
    }

    @Override // com.sigmob.sdk.videocache.c
    public synchronized boolean d() {
        return !a(this.f3661a);
    }

    public File e() {
        return this.f3661a;
    }
}
